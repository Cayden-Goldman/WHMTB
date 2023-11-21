using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount = 10;

    [SerializeField]
    private float startAngle = 160f, endAngle = 200f;

    private Vector2 bulletMoveDirection;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 1f);
    }

    void Update()
    {
        float xPlayer = GameObject.Find("Player").transform.position.x;
        float yPlayer = GameObject.Find("Player").transform.position.y;
        float xThis = GetComponent<Transform>().position.x;
        float yThis = GetComponent<Transform>().position.y;
        float angleToPlayer = 270 - (Mathf.Rad2Deg * Mathf.Atan2(yThis - yPlayer, xThis - xPlayer));
        startAngle = angleToPlayer - 20f;
        endAngle = angleToPlayer  + 20f;
    }

    private void Fire()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }
}
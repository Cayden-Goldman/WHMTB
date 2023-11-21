using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    float moveSpeed, radius;
    float angle;

    void Start()
    {

    }

    void Update()
    {
        angle += (moveSpeed / (radius * (Mathf.PI) * 2)) * Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;
    }
}

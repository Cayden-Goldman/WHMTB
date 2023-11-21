using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DEATH : MonoBehaviour
{
    private bool dead = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            dead = true;
        }
    }

    private void Update()
    {
        if (dead == true)
        {
            SceneManager.LoadScene("RetryScreen");
            dead = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject ending;
    void OnTriggerEnter2D(Collider2D other)
    {
     if (other.gameObject.CompareTag("Player"))
       {

            ending.SetActive(true);
            Time.timeScale = 0;
       }        
    }
}

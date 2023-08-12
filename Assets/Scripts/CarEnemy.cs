using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnemy : MonoBehaviour
{
    [SerializeField] Rigidbody2D car;
    [SerializeField] float speed = 25f;
    float lifetime = 15f;

    void Update()
    {
        lifetime -= Time.deltaTime;
        car.transform.position = transform.position + transform.right* (speed* Time.deltaTime);

        if (lifetime < 0.1f) 
            { 
               Destroy(this.gameObject);                                                                         
          }

        if (speed < 0f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
}

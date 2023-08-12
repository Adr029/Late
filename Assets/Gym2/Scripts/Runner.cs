using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D runner;
    [SerializeField] bool movementdown;
    public Transform wallDetector;
    [SerializeField] bool movingDown = true;
    [SerializeField] Animator animate;

    void Update()
    {

        transform.Translate(Vector2.down * speed * Time.deltaTime);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetector.position, Vector2.down, 0.1f);
       
        if (wallInfo)
        {
            if (wallInfo.collider.tag == "Wall")
            {
                if (movingDown == true)

                {
                    speed *= -1f;
                    movingDown = false;
                } 
            }
           
        }
        if (movingDown == false && transform.position.y > 14)

        {
            speed *= -1f;
            movingDown = true;
        }
        animate.SetFloat("speed", speed);

    }
}

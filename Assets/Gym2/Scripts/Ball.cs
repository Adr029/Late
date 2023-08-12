using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed = 18f;
    public Rigidbody2D balls;
    public Transform catchDetector;
    bool movingUp = true;
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        RaycastHit2D ballInfo = Physics2D.Raycast(catchDetector.position, Vector2.up, 0.5f);



        if (ballInfo)
        {

            if (ballInfo.collider.tag == "PE")
            {
                if (movingUp == true)

                {
                    transform.eulerAngles = new Vector3(180, 0, 0);
                    movingUp = false;
                }

                else

                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingUp = true;
                }
            }
        }






    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeacher : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D teacher;
    [SerializeField] Transform target;
    public Transform wallDetector;
    public Transform detectorLeft;
    public bool movingRight = true;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetector.position, Vector2.right, 1f);

        if (wallInfo)
        {

            if (wallInfo.collider.tag == "Wall")
            {
                if (movingRight)

                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                    movingRight = false;
                }

                else

                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
            }
        }
        RaycastHit2D sightInfo = Physics2D.Raycast(wallDetector.position, Vector2.right, 20f);
        RaycastHit2D sightInfoLeft = Physics2D.Raycast(detectorLeft.position, Vector2.left, 20f);
        float dist = Mathf.Abs(teacher.transform.position.x - target.transform.position.x);

        if (movingRight)
        {

            if (sightInfo)
            {
                if (sightInfo.collider.tag == "Player")
                {

                    if (dist < 20f)
                    {
                        
                        teacher.transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), 9 * Time.deltaTime);
                    }
                }
                else
                {
                    speed = 5f;
                }

            }

        }
        if (!movingRight)
        {

            if (sightInfoLeft)
            {
                if (sightInfoLeft.collider.tag == "Player")
                {

                    if (dist < 20f)
                    {
                        
                        teacher.transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), 9 * Time.deltaTime);
                    }
                }
                else
                {
                    speed = 5f;
                }

            }

        }


    }
}

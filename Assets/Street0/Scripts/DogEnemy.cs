using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogEnemy : MonoBehaviour
{
    [SerializeField] Rigidbody2D dog;
    [SerializeField] Transform target;
    [SerializeField] float speed = 11f;
    Vector2 startPos;
    [SerializeField] private AudioSource bark;

    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //code para habulin ng dog yung player
        if (Vector2.Distance(target.position, dog.position) < 10f)
        {
            dog.transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (!bark.isPlaying)
            {
                bark.Play();
            }

            if (target.position.x > transform.position.x)
            {

                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (target.position.x < transform.position.x)
            {

                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (Vector2.Distance(target.position, dog.position) > 9f)
            {
                dog.transform.position = Vector2.MoveTowards(dog.position, startPos, speed * Time.deltaTime);
                if (bark.isPlaying)
                {
                    bark.Stop();
                }

            }

        }
        if (Vector2.Distance(target.position, dog.position) > 9f)
        {
            dog.transform.position = Vector2.MoveTowards(dog.position, startPos, speed * Time.deltaTime);

        }
        if (Time.timeScale == 0)
        {
            bark.Stop();

        }



    }
}

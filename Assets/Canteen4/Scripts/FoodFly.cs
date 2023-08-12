using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFly : MonoBehaviour
{
    float speed = 14f;
    float alivetime = 20f;
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    void FixedUpdate()
    {
        alivetime -= Time.deltaTime;
        if (alivetime < 0.1f)
        {
            Destroy(this.gameObject);

        }
    }
}

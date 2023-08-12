using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject bread;
    public GameObject coke;
    public GameObject hakdog;
    public GameObject pancake;
    public GameObject pizza1;
    public GameObject pizza2;
    public GameObject siopao;
    public float spawntime = 3f;

    void Update()

    {


        spawntime -= Time.deltaTime;
        if (spawntime < 0f)
        {
            spawntime = 3f;

            Vector3 randomSpawn = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn2 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn3 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn4 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn5 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn6 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
            Vector3 randomSpawn7 = new Vector3(Random.Range(-18, -3f), Random.Range(-21, 15f));
           

            Instantiate(bread, randomSpawn, Quaternion.identity);
            Instantiate(coke, randomSpawn2, Quaternion.identity);
            Instantiate(hakdog, randomSpawn3, Quaternion.identity);
            Instantiate(pancake, randomSpawn4, Quaternion.identity);
            Instantiate(pizza1, randomSpawn5, Quaternion.identity);
            Instantiate(pizza2, randomSpawn6, Quaternion.identity);
            Instantiate(siopao, randomSpawn7, Quaternion.identity);
        }




    }
}

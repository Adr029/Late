using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject GreenCar;
    public GameObject RedCar;
    // public GameObject PinkCar;
    public GameObject GreenCarLeft;
    public GameObject RedCarLeft;
    public float spawntime = 2.5f;

    void Update()

    {


        spawntime -= Time.deltaTime;
        if (spawntime < 0f)
        {
            //right
            spawntime = 2.5f;
            Vector3 randomSpawn = new Vector3(Random.Range(0, -10f), -6.5f);
            Vector3 randomSpawn2 = new Vector3(Random.Range(0, -7f), -10f);
            //Vector3 randomSpawn3 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));

            //left cars
            Vector3 LeftrandomSpawn = new Vector3(Random.Range(250, 240f), 1.3f);
            Vector3 LeftrandomSpawn2 = new Vector3(Random.Range(250, 240f), -2.3f);

            Instantiate(GreenCar, randomSpawn, Quaternion.identity);
            Instantiate(RedCar, randomSpawn2, Quaternion.identity);
            Instantiate(GreenCarLeft, LeftrandomSpawn2, Quaternion.identity);
            Instantiate(RedCarLeft, LeftrandomSpawn, Quaternion.identity);
           // Instantiate(PinkCar, randomSpawn3, Quaternion.identity);
         
        }




    }
}

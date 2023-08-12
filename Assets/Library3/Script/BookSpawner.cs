using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawner : MonoBehaviour
{
    public GameObject BlueBook;
    public GameObject GreenBook;
    public GameObject BrownBook;
    public GameObject OrangeBook;
    public GameObject BlueBook2;
    public GameObject GreenBook2;
    public GameObject BrownBook2;
    public GameObject OrangeBook2;
    public float spawntime = 5f;
  
    void Update()

    {

    
        spawntime -= Time.deltaTime;
          if (spawntime < 0f)
          {
                spawntime = 5f;
                Vector3 randomSpawn = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn2 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn3 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn4 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn5 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn6 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn7 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                Vector3 randomSpawn8 = new Vector3(Random.Range(-18, -3f), Random.Range(-20, 15f));
                
                Instantiate(BlueBook, randomSpawn, Quaternion.identity);
                Instantiate(GreenBook, randomSpawn2, Quaternion.identity);
                Instantiate(BrownBook, randomSpawn3, Quaternion.identity);
                Instantiate(OrangeBook, randomSpawn4, Quaternion.identity);
                Instantiate(BlueBook2, randomSpawn5, Quaternion.identity);
                Instantiate(GreenBook2, randomSpawn6, Quaternion.identity);
                Instantiate(BrownBook2, randomSpawn7, Quaternion.identity);
                Instantiate(OrangeBook2, randomSpawn8, Quaternion.identity);
         }


        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{

    [SerializeField] Player playertime;
    [SerializeField] Text Time;

    // Start is called before the first frame update
    void Start()
    {
        playertime.alivetime = 90;
    }

    // Update is called once per frame
    void Update()
    {
        if (playertime.alivetime <= 20.5f)
        {
            Time.color = Color.yellow;
            if (playertime.alivetime <= 10.5f)
            {
                Time.color = Color.red;

            }

        }
        else
        {
            Time.color = Color.white;

        }
        Time.text = playertime.alivetime.ToString("N0");
       
    }
}

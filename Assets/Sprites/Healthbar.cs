using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] Player health;
    [SerializeField] Image Health;


    private void Start()

    {

        Health.fillAmount = 1f;
    }


    private void Update()
    {
        if (health.playerhealth == 3f)
            Health.fillAmount = 0.65f;
        else if (health.playerhealth == 2f)
        {
            Health.fillAmount = 0.35f;
        }
        else if (health.playerhealth == 1f)
        {
            Health.fillAmount = 0f;

        }
    }
}

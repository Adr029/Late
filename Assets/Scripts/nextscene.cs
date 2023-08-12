using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextscene : MonoBehaviour
{
    public Animator animate;
    public string nextLevel;
    public Image img;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
         
            StartCoroutine(Fade());

        }
        IEnumerator Fade()
        {
            animate.SetBool("Fade", true);
            yield return new WaitUntil(() => img.color.a == 1);
            SceneManager.LoadScene(nextLevel);
            Time.timeScale = 1;
        }
    }
}

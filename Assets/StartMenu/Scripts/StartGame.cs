using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour
{

    public Animator animate;
    public Image img;
    private int sceneToContinue;

    public void GameStart()
    {
        StartCoroutine(Fade());
    }
    public void ExitGame()
    {
        StartCoroutine(Exit());
    }

    public void LoadGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        StartCoroutine(Load());

    }

    IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene(1);
    }
    IEnumerator Exit()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        Application.Quit();
    }
    IEnumerator Load()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene(sceneToContinue);
    }

}

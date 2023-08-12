using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Pause : MonoBehaviour
{

    public GameObject pause;
    public GameObject saved;
    public GameObject GameOver;
    bool paused = false;
    [SerializeField] Player playercode;
    [SerializeField] AudioSource bg;
    public GameObject InitialPopUp;

    int currentSceneIndex;

    void Start()
    {
        pause.SetActive(false);
        GameOver.SetActive(false);
        InitialPopUp.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
            paused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Resume();   
        }

        if (playercode.playerhealth == 0 || playercode.alivetime < 0.1)
        {
            GameOver.SetActive(true);
           
        }

    }
    public void Resume()
    {
        bg.Play();
        pause.SetActive(false);
        saved.SetActive(false);
        InitialPopUp.SetActive(false);

        Time.timeScale = 1;
        paused = false;
        
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Save()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        saved.SetActive(true);
        pause.SetActive(false);
    }


}
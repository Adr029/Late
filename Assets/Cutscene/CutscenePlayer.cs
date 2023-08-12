using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutscenePlayer : MonoBehaviour
{
    public GameObject Frame1;
    public GameObject Frame2;
    public GameObject Frame3;
    public GameObject Frame4;
    public GameObject Frame5;
    public GameObject Frame6;
    public int frame = 0;
    [SerializeField] AudioSource frame1;
    [SerializeField] AudioSource frame2;
    [SerializeField] AudioSource frame3;
    [SerializeField] AudioSource frame4;
    [SerializeField] AudioSource frame5;
    [SerializeField] AudioSource frame6;
    public Animator animate;
    public Image img;

    void Start()
    {
        Frame1.SetActive(true);
        frame = 1;
        frame1.Play();
    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 1)
        {
            Frame2.SetActive(true);
            frame = 2;
            frame1.Stop();
            frame2.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 2)
        {
            Frame3.SetActive(true);
            frame = 3;
            frame2.Stop();
            frame3.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 3)
        {
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(true);
            frame = 4;
            frame3.Stop();
            frame4.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 4)
        {
            Frame5.SetActive(true);
            frame = 5;
            frame4.Stop();
            frame5.Play();

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 5)
        {
            Frame6.SetActive(true);
            frame = 6;
            frame5.Stop();
            frame6.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && frame == 6)
        {
            StartCoroutine(Fade());
        }

        IEnumerator Fade()
        {
            animate.SetBool("Fade", true);
            yield return new WaitUntil(() => img.color.a == 1);
            SceneManager.LoadScene(2);
        }

    }
}

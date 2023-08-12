using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    float speed = 5f;
    float x;
    float y;
    [SerializeField] bool faceright = true;
    public float playerhealth = 4f;
    Vector3 startPos;
    [SerializeField] Rigidbody2D player;
    float move;
    float moveY;
    public bool sprint = false;
    public float alivetime;
    [SerializeField] Animator animator;
    [SerializeField] private AudioSource walkingsound;
    [SerializeField] private AudioSource sprintingsound;
    [SerializeField] bool dead = false;
    [SerializeField] AudioSource bg;
    [SerializeField] AudioSource death;
    [SerializeField] AudioSource music;
    [SerializeField] bool crawl = false;

    void Start()
    {
        startPos = this.transform.position;
        alivetime = 90f;

    }
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        alivetime -= Time.deltaTime;
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            walkingsound.Play();
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                walkingsound.Stop();
            }
        if (walkingsound.isPlaying && Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintingsound.Play();
        }
        else if (!sprint)
        {
            sprintingsound.Stop();
        }

        if (sceneName == "Street0" || sceneName == "School1" || sceneName == "Gym2" || sceneName == "SchoolFinal5")
            {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprint = true;
                speed = 12f;
            }
            else
            {
                speed = 5f;
                sprint = false;
            }
        }
        else if (sceneName == "Library3" || sceneName == "Canteen4")
        {

            if (Input.GetKey(KeyCode.LeftControl))
            {

                speed = 2f;
                crawl = true;
            }

            else
            {
                speed = 5f;
                crawl = false;
            }
        }
        if (Time.timeScale == 0)
        {
            bg.Pause();
            music.Pause();
        }
        if (Time.timeScale == 1 && !music.isPlaying)
        {
            music.Play();
        }

        //animator

        animator.SetFloat("speedY", y);
        animator.SetBool("dead", dead);
        animator.SetBool("crawling", crawl);
        animator.SetFloat("speed", Mathf.Abs(x));

    }
 
    private void FixedUpdate()
    {
        XMovement(x);
        YMovement(y);

    }

    private void XMovement(float move)
    {
        float xvelocity = move * speed * 50 * Time.deltaTime;
        Vector2 targetvelocity = new Vector2(xvelocity, player.velocity.y);
        player.velocity = targetvelocity;
        if (faceright && move < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            faceright = false;
        }
        else if (!faceright && move > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            faceright = true;
        }
    }
    private void YMovement(float moveY)
    {
        float yvelocity = moveY * speed * 50 * Time.deltaTime;
        Vector2 targetvelocity = new Vector2(player.velocity.x, yvelocity);
        player.velocity = targetvelocity;

    }

    void OnTriggerEnter2D(Collider2D collisions)
    {
        if (collisions.gameObject.tag == "Enemy" && !crawl)
        {
            bg.Stop();
            
            playerhealth = playerhealth - 1f;
            dead = true;
            Time.timeScale = 0;
            if (playerhealth > 0f)
            {
                death.Play();
                StartCoroutine(Respawn(5f));
            }

        }

        IEnumerator Respawn(float time)
        {
            yield return new WaitForSecondsRealtime(5f);
                this.transform.position = startPos;
                dead = false;
                Time.timeScale = 1;
                 alivetime = 90f;
                 bg.Play();
        }
    }
} 




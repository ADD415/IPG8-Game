using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Spawner spawner;
    public UIManager manager;
    public ToggleVis Vis;
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;
    AudioSource jumpsound;
    private Rigidbody2D _rigidbody;
    public Animator animator;
    public GameObject vent1Exit;
    public GameObject vent2Exit;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
         jumpsound = GetComponent<AudioSource>();
    }

    void Update()
    {
        PlayerMove();

        if (UIManager.lives == -1)
        {
            SceneManager.LoadScene("GameOver");
            Time.timeScale = 0f;
        }
    }

    void PlayerMove()
    {
        //Controls, animations, player direction, physics 

        //Controls
        moveX = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveX));


        //Player Direction
        if (moveX > 0.0f && facingRight == false)
        {
            FlipPlayer();
        }

        else if (moveX < 0.0f && facingRight == true)
        {
            FlipPlayer();
        }

        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            Jump();
            jumpsound.Play();
        }

    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }



    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Death"))
        {
            Destroy(gameObject);
            spawner.CheckValue();
            manager.lifeLost();

        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {

            case "Room2":
                SceneManager.LoadScene("Room 2");
                break;

            case "Room3":             
                SceneManager.LoadScene("Room 3");
                break;

            case "Room4":
                SceneManager.LoadScene("Room 4");
                break;

            case "Room5.1":
                SceneManager.LoadScene("Room 5.1");
                break;

            case "Room5.2":
                SceneManager.LoadScene("Room 5.2");
                break;

            case "Room5.3":
                SceneManager.LoadScene("Room 5.3");
                break;

            case "Room6":
                SceneManager.LoadScene("Room 6");
                break;

            case "Room7":
                SceneManager.LoadScene("Room 7");
                break;

            case "Room8":
                SceneManager.LoadScene("Room 8");
                break;

            case "Room9":
                SceneManager.LoadScene("Room 9");
                break;

            case "Room10":
                SceneManager.LoadScene("Room 10");
                break;

            case "Room11":
                SceneManager.LoadScene("Room 11");
                break;

            case "Room12":
                SceneManager.LoadScene("Room 12");
                break;

            case "End":
                SceneManager.LoadScene("End");
                Time.timeScale = 0f;
                break;

        }
    }

    public void setPositionVent1()
    {
        GameObject.Find("Player(Arm)(Clone)").transform.position = vent1Exit.transform.position;
    }

    public void setPositionVent2()
    {
        GameObject.Find("Player(BothArms)(First)(Clone)").transform.position = vent2Exit.transform.position;
    }
}

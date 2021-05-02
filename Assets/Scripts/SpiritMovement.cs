using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public CaseActivation Case;
    public DinoActivation1 dino;
    private bool facingRight = true;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (movement.x > 0.0f && facingRight == false)
        {
            FlipPlayer();
        }

        else if (movement.x < 0.0f && facingRight == true)
        {
            FlipPlayer();
        }


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

     void OnCollisionEnter2D(Collision2D other)
     {
         if (other.gameObject.name == "Possesable_case_" && Input.GetKey(KeyCode.Space))
         {
            
            Case.CaseActivate();
            Destroy(gameObject);

         }
         else if (other.gameObject.name == "Diplo" && Input.GetKey(KeyCode.Space))
        {
            dino.DinoActivate();
            Destroy(gameObject);
        }
        
     }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }


}
 

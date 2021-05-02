using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovemnt : MonoBehaviour
{
    Vector2 movement;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;


    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}

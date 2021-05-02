using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseMovement : MonoBehaviour
{
    Vector2 movement;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

   /* void Start()
    {
        GetComponent<CaseActivation>().enabled = true;
    }*/

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}

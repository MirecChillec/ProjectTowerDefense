using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    float moveSpeed;
    Vector2 move;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 200f;
    }

   
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(move * moveSpeed * Time.deltaTime);
    }

}

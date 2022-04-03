using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerrr : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    private Rigidbody2D rb2D;
    float moveSpeed;
    Vector2 move;
    void Start()
    {
        currentHealth = maxHealth;
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

    public void TakeDamage(int damage)
    {
        currentHealth-= damage;

        //animacka

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
    }   
}

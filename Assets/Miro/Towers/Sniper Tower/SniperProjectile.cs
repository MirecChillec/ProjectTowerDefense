using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperProjectile : MonoBehaviour
{
    public SniperTower sniperScript;
    public bool isRising;
    public bool isFalling;

    public GameObject explosion;

    public void Fall()
    {
        this.gameObject.transform.position = sniperScript.enemies[0].gameObject.transform.position + new Vector3(0, 10, 0);
    }

    public void Explode()
    {
        Instantiate(explosion);
        Destroy(this.gameObject);
    }

    void Update()
    {
        if (isRising)
        {
            this.gameObject.transform.Translate(0, +0.1f, 0);
            if(this.gameObject.transform.position.y >= 10)
            {
                isRising = false;
                isFalling = true;
            }
        }
        else if (isFalling) 
        {
            this.gameObject.transform.Translate(0, -0.1f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Explode();
        }
    }
}

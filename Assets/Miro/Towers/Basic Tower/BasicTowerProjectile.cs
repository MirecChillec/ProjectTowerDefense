using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTowerProjectile : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Destruction());
    }

    IEnumerator Destruction()
    {
        yield return new WaitForSeconds(10f);
        Destroy(this.gameObject);
        
    }
    private void FixedUpdate()
    {
        this.transform.Translate(0.1f, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Instantiate();
    }
}

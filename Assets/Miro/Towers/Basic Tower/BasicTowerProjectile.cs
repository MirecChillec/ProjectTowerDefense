using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTowerProjectile : MonoBehaviour
{
    public GameObject basicTower;
    public GameObject explosion;
    public int damage;
    void Start()
    {
        damage = basicTower.GetComponentInChildren<BasicTower>().damage;
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit");
            Instantiate(explosion, this.gameObject.transform.position + Vector3.right * 0.2f, new Quaternion(0,0,0,0));
            Destroy(this.gameObject);
        }
    }
}

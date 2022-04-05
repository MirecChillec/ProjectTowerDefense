using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicProjectile : MonoBehaviour
{
    public GameObject basicEnemy;
    public GameObject explosion;
    public int damage;
    void Start()
    {
        damage = basicEnemy.GetComponentInChildren<EnemyBasic>().damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tower"))
        {
            Debug.Log("hit");
            Instantiate(explosion, this.gameObject.transform.position + Vector3.right * -0.2f, new Quaternion(0, 0, 0, 0));
            Destroy(this.gameObject);
        }
    }

    public void Obliterate()
    {
        Destroy(this.gameObject);
    }
}

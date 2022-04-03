using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperTower : TowerBase
{
    public List<GameObject> enemies = new List<GameObject>();
    public override void Attack()
    {

    }

    public override void Idle()
    {

    }

    public override void Shoot()
    {

    }

    public override void Update()
    {
        base.Update();

        if(enemies != null)
        {

        }
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemies.Add(collision.gameObject);
        }
    }
}

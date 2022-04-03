using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mothEnemy : enemyClass
{
    public GameObject projectile;
    public Transform shotPoint;
    public override void Attack()
    {
        if(timeStamp <= Time.time)
        {
            animator.SetTrigger("Attack");

            Instantiate(projectile, shotPoint.position, transform.rotation);

            Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

            foreach(Collider2D tower in hitTowers)
            {
                tower.GetComponent<TowerBase>().TakeDamage(attackDamage);
            } 

            timeStamp = Time.time + coolDownInSeconds;
        }
    }
}

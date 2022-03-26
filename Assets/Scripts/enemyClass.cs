using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClass : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask towerLayer;

    public Animator animator;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

        foreach(Collider2D tower in hitTowers)
        {
            Debug.Log("We hit " + tower.name);
        }
    }
    void OnDrawGizmosSelected() 
    {
        if (attackPoint == null)
        return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

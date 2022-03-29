using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClass : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask towerLayer;
    public int attackDamage = 2;
    public float walkSpeed;
    public bool isMoving;
    public bool inRange;
    public Rigidbody2D rb;
    public Animator animator;
    public float timeStamp;
    public float coolDownInSeconds = 5f;
    private void Start() 
    {
        isMoving = true;
        inRange = false;
    }
    void Update()
    {
        if(isMoving)
        {
            rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
        }
        if(inRange)
        {
            isMoving = false;
            rb.velocity = new Vector2(0, 0);
            Attack();
        }
    }
    public virtual void Attack()
    {
        if(timeStamp <= Time.time)
        {
            animator.SetTrigger("Attack");

            Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

            foreach(Collider2D tower in hitTowers)
            {
                tower.GetComponent<towerrr>().TakeDamage(attackDamage);
            }
            timeStamp = Time.time + coolDownInSeconds;
        }    
    }
    void OnDrawGizmosSelected() 
    {
        if (attackPoint == null)
        return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    private void OnTriggerStay2D(Collider2D trig) 
    {
        if(trig.gameObject.tag == "Tower")
        {
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D trig) 
    {
        if(trig.gameObject.tag == "Tower")
        {
            inRange = false;
            isMoving = true;
        }
    }
}

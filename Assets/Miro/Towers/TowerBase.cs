using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TowerBase : MonoBehaviour
{
    public int health;
    public int damage;
    public int cost;
    public float attackSpeed;
    public float lastTimeGotDamage=float.NegativeInfinity;
    public string keyShortcut;
    public string currentState;
    public bool isDisabled = false;
    public bool isVulnerable = true;
    public float time;

    public GameObject projectile;
    public Transform position;
    public Animator towerAnimator;
    public BoxCollider2D rangeColider;
    public BoxCollider2D solidColider;
    public SpriteRenderer spriteRenderer;
    public Color damageColor = Color.red;
    public Color normalColor = Color.white;
    public Money money;

    public virtual void Start()
    {
        money = GameObject.Find("Money").GetComponent<Money>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        towerAnimator = GetComponent<Animator>();
        position = this.gameObject.transform;
        time = attackSpeed;
        Idle();
    }

    public abstract void Attack();

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        lastTimeGotDamage = Time.time;
    }

    public virtual void Sell()
    {
        ChangeAnimationState("Death");
        Destroy(this.gameObject);
    }

    public abstract void Idle();

    public virtual void Death()
    {
        ChangeAnimationState("Death");
    }

    public virtual void Obliterate()
    {
        Destroy(this.gameObject);
    }

    public virtual void Stunned()
    {
        Idle();
        spriteRenderer.enabled = false;
        rangeColider.enabled = false;
        solidColider.enabled = false;
    }

    public virtual void Unstunned()
    {
        spriteRenderer.enabled = true;
        rangeColider.enabled = true;
        solidColider.enabled = true;
    }

    public abstract void Shoot();

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && time>=attackSpeed)
        {
            Attack();
            time = 0;
        }
    }

    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Idle();
        }
    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
            TakeDamage(collision.gameObject.GetComponent<EnemyBasicProjectile>().damage);
        }
    }

    public virtual void Update()
    {
        if (spriteRenderer)
        {
            spriteRenderer.color = Color.Lerp(damageColor, normalColor, Time.time-lastTimeGotDamage);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            lastTimeGotDamage = Time.time;
        }

        if (health <= 0)
        {
            Death();
        }

        time += Time.time * Time.deltaTime;
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        towerAnimator.Play(newState);

        currentState = newState;
    }
}

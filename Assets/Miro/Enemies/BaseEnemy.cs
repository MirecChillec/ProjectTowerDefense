using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    public int health;
    public int damage;
    public float attackSpeed;
    public float lastTimeGotDamage = float.NegativeInfinity;
    public string keyShortcut;
    public string currentState;
    public int walkSpeed = 1;
    public float time;

    public GameObject projectile;
    public Transform position;
    public Animator towerAnimator;
    public BoxCollider2D rangeColider;
    public SpriteRenderer spriteRenderer;
    public Color damageColor = Color.gray;
    public Color normalColor = Color.white;
    public bool detectTower = false;

    public virtual void Start()
    {
        rangeColider = GetComponent<BoxCollider2D>();
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


    public abstract void Idle();

    public virtual void Death()
    {
        ChangeAnimationState("Death");
    }

    public virtual void Obliterate()
    {
        Destroy(this.gameObject);
    }

    public abstract void Shoot();



    public virtual void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tower"))
        {
            detectTower = false;
            Idle();
        }
    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TowerProjectile"))
        {
            TakeDamage(collision.gameObject.GetComponent<BasicTowerProjectile>().damage);
        }
        if (collision.gameObject.CompareTag("Tower"))
        {
            detectTower = true;
            Attack();
        }
    }

    public abstract void Wait();

    public virtual void Update()
    {
        if (spriteRenderer)
        {
            spriteRenderer.color = Color.Lerp(damageColor, normalColor, Time.time - lastTimeGotDamage);
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

        if (detectTower==false)
        {
            this.gameObject.transform.Translate(-0.3f * walkSpeed*Time.deltaTime, 0, 0);
        }
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        towerAnimator.Play(newState);

        currentState = newState;
    }
}

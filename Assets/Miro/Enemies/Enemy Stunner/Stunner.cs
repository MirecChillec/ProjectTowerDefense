using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stunner : BaseEnemy
{
    public GameObject currentHold;

    public override void Attack()
    {

    }

    public override void Idle()
    {
        ChangeAnimationState("Walk");
    }

    public override void Shoot()
    {

    }

    public override void Wait()
    {

    }

    public void StunBasic()
    {
        ChangeAnimationState("StunBasic");
    }

    public void StunGenerator()
    {
        ChangeAnimationState("StunGenerator");
    }

    public void StunSniper()
    {

        ChangeAnimationState("StunSniper");
    }

    public void StunTank()
    {
        ChangeAnimationState("StunTank");
    }

    IEnumerator Damage(TowerBase toDamage)
    {
        while (toDamage != null)
        {
            toDamage.health -= 5;
            yield return new WaitForSeconds(1f);
        }
        
        toDamage.Unstunned();
        Idle();

        yield return null;
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TowerProjectile"))
        {
            TakeDamage(collision.gameObject.GetComponent<BasicTowerProjectile>().damage);
        }
        if (collision.gameObject.CompareTag("Tower"))
        {
            ChangeAnimationState("Attack");
            rangeColider.enabled = false;
            detectTower = true;
            StartCoroutine(Damage(collision.gameObject.GetComponent<TowerBase>()));
            if(collision.gameObject.TryGetComponent<BasicTower>(out BasicTower basicTower))
            {
                StunBasic();
            }
            else if (collision.gameObject.TryGetComponent<TankTower>(out TankTower tankTower))
            {
                collision.gameObject.GetComponent<TankTower>().shieldActive = false;
                collision.gameObject.GetComponent<TankTower>().shieldColider.enabled = false;
                collision.gameObject.GetComponent<TankTower>().shieldRenderer.enabled = false;

                StunTank();
            }
            else if (collision.gameObject.TryGetComponent<SniperTower>(out SniperTower sniperTower))
            {
                StunSniper();
            }
            else if (collision.gameObject.TryGetComponent<GeneratorTower>(out GeneratorTower generatorTower))
            {
                StunGenerator();
            }
            collision.gameObject.GetComponent<TowerBase>().Stunned();
        }
    }
}

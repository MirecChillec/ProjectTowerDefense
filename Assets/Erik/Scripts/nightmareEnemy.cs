using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightmareEnemy : enemyClass
{
    public bool baseTower = false;
    public bool generatorTower = false;
    public bool tankTower = false;
    public bool sniperTower = false;

    public override void Attack()
    {
        if(timeStamp <= Time.time)
        {
            if(baseTower == true)
            {
                animator.SetTrigger("AttackBaseTower");

                Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

                foreach(Collider2D tower in hitTowers)
                {
                    tower.GetComponent<TowerBase>().TakeDamage(attackDamage);
                }
                timeStamp = Time.time + coolDownInSeconds;
            }
            if(tankTower == true)
            {
                animator.SetTrigger("AttackTankTower");

                Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

                foreach(Collider2D tower in hitTowers)
                {
                    tower.GetComponent<TowerBase>().TakeDamage(attackDamage);
                }
                timeStamp = Time.time + coolDownInSeconds;
            }
            if(sniperTower == true)
            {
                animator.SetTrigger("AttackSniperTower");

                Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

                foreach(Collider2D tower in hitTowers)
                {
                    tower.GetComponent<TowerBase>().TakeDamage(attackDamage);
                }
                timeStamp = Time.time + coolDownInSeconds;
            }
            if(generatorTower == true)
            {
                animator.SetTrigger("AttackGeneratorTower");

                Collider2D[] hitTowers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, towerLayer);

                foreach(Collider2D tower in hitTowers)
                {
                    tower.GetComponent<TowerBase>().TakeDamage(attackDamage);
                }
                timeStamp = Time.time + coolDownInSeconds;
            }
        }
    }
    public override void OnTriggerStay2D(Collider2D trig) 
    {
        if(trig.gameObject.tag == "Tower")
        {
            inRange = true;
            if(trig.gameObject.TryGetComponent<BasicTower>(out BasicTower basic))
            {
                baseTower = true;
            }
            if(trig.gameObject.TryGetComponent<TankTower>(out TankTower tank))
            {
                tankTower = true;
            }
            if(trig.gameObject.TryGetComponent<SniperTower>(out SniperTower sniper))
            {
                sniperTower = true;
            }
            if(trig.gameObject.TryGetComponent<GeneratorTower>(out GeneratorTower generator))
            {
                generatorTower = true;
            }
        }
    }
    public override void OnTriggerExit2D(Collider2D trig) 
    {
        if(trig.gameObject.tag == "Tower")
        {
            inRange = false;
            isMoving = true;
            baseTower = false;
            tankTower = false;
            sniperTower = false;
            generatorTower = false;
        }
    }
}

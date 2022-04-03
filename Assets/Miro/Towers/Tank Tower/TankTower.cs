using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTower : TowerBase
{
    public SpriteRenderer shieldRenderer;
    public BoxCollider2D shieldColider;
    public Shield shieldScript;
    public bool shieldActive = false;
    public override void Start()
    {
        base.Start();
        shieldRenderer=projectile.GetComponent<SpriteRenderer>();
        shieldColider = projectile.GetComponent<BoxCollider2D>();
        shieldScript = projectile.GetComponent<Shield>();
    }

    public override void Update()
    {
        base.Update();
        if (shieldScript.currentHealth < 1)
        {
            ChangeAnimationState("Tank_Tower_Idle");
        }
    }

    public override void Attack()
    {
        if (shieldScript.currentHealth >= 10)
        {
            if (shieldScript.currentHealth >= 75)
            {
                ChangeAnimationState("Tank_Attack_100");
            }
            else if (shieldScript.currentHealth >= 50 && shieldScript.currentHealth < 75)
            {
                ChangeAnimationState("Tank_Attack_75");
            }
            else if (shieldScript.currentHealth >= 25 && shieldScript.currentHealth < 50)
            {
                ChangeAnimationState("Tank_Attack_50");
            }
            else if (shieldScript.currentHealth > 0 && shieldScript.currentHealth < 25)
            {
                ChangeAnimationState("Tank_Attack_25");
            }
        }
        else
        {
            //show that shield is unusable
        }
    }

    public override void Idle()
    {
        shieldRenderer.enabled = false;
        shieldScript.canRecharge = true;
        ChangeAnimationState("Tank_Tower_Idle");
    }

    public override void Shoot()
    {
       
        ChangeAnimationState("Tank_Shielded");
        shieldRenderer.enabled = true;
        shieldScript.canRecharge = false;
    }
}

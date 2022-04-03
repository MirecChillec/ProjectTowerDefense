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
        if (shieldScript.currentHealth < 10)
        {
            ChangeAnimationState("Tank_Tower_Idle");
        }
    }

    public override void Attack()
    {
        if (shieldScript.currentHealth >= 10)
        {
            ChangeAnimationState("Tank_Attack");
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

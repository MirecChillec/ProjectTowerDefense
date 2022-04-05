using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTower : TowerBase
{
    public override void Start()
    {
        base.Start();
    }
    public override void Attack()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeAnimationState("Generator_Generate");
    }

    public override void Idle()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeAnimationState("Generator_Idle");
    }

    public override void Sell()
    {
        money.money += money.generatorCost / 100 * 25;
        base.Sell();
    }

    public override void Shoot()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        money.money += 25;
        Instantiate(projectile, this.gameObject.transform.position + new Vector3(-0.2f,2,0),new Quaternion (0,0,0,0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTower : TowerBase
{
    public int moneyToGenerate = 50;
    public GameObject coin;

    public override void Attack()
    {
        ChangeAnimationState("Generator_Generate");
    }

    public override void Idle()
    {
        ChangeAnimationState("Generator_Idle");
    }

    public override void Shoot()
    {
        Instantiate(coin);
        //gameManager.Total += moneyToGenerate;
    }
}

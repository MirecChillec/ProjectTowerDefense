using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTower : TowerBase
{
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
        //add money
        Instantiate(projectile, this.gameObject.transform.position + new Vector3(-0.2f,2,0),new Quaternion (0,0,0,0));
    }
}

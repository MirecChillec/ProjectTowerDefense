using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTower : TowerBase
{
    public override void Attack()
    {
        ChangeAnimationState("Basic_Tower_Attack");
    }

    public override void Idle()
    {
        ChangeAnimationState("Basic_Tower_Idle");
    }

    public override void Shoot()
    {
        Instantiate(projectile, this.gameObject.transform.position + Vector3.right, new Quaternion(0,0,0,0));
    }
}

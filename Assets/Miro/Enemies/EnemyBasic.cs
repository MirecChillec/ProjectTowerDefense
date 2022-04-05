using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : BaseEnemy
{
    public override void Attack()
    {
        ChangeAnimationState("Attack");
    }

    public override void Idle()
    {
        ChangeAnimationState("Walk");
    }

    public override void Shoot()
    {
        Instantiate(projectile,this.gameObject.transform.position+new Vector3(-1,0,0),new Quaternion(0,0,0,0));
    }

    public override void Wait()
    {
        ChangeAnimationState("Wait");
    }
}

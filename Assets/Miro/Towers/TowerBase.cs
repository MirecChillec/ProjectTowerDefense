using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TowerBase : MonoBehaviour
{
    public int health;
    public int damage;
    public int cost;
    public float attackSpeed;
    public string keyShortcut;

    public Animator towerAnimator;

    public abstract void Attack();

    public abstract void Sell();

    public abstract void Idle();

    public abstract void Upgrade();

    public abstract void Death();

}

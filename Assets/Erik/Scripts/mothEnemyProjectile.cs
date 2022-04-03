using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mothEnemyProjectile : MonoBehaviour
{
    public float lifeTime;

    private void Start() 
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}

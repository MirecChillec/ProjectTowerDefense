using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScript : MonoBehaviour
{
    // Start is called before the first frame update
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

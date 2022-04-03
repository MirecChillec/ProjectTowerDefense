using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.transform.Translate(0, 0.1f, 0);
    }

    public void Obliterate()
    {
        Destroy(this.gameObject);
    }
}

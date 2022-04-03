using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactBehaviour : MonoBehaviour
{
    public void Obliterate()
    {
        Destroy(this.gameObject);
    }
}

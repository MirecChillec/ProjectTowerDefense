using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasTile : MonoBehaviour
{
    public UnityEvent<Collider2D> myEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Placeable"))
        {
            myEvent.Invoke(collision);
        }
    }
}

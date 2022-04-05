using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
    public string towerType;
    public Camera cam;
    public bool isNotPlaced = true;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,cam.nearClipPlane));
        }
        else
        {
            this.gameObject.transform.Translate(0,0,-this.gameObject.transform.position.z);
            this.gameObject.GetComponent<Collider2D>().enabled = true;
            if (isNotPlaced)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void PlaceDown()
    {
        this.gameObject.GetComponent<Collider2D>().enabled = true;
        if (isNotPlaced)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Canvas Tile"))
        {
            isNotPlaced = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class SeedPacketsheep : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag3;
    public GameObject object_game3;
    public Canvas canvas;



    private GameObject ObjectDragInstance3;
    private GameManager gameManager;




    private void Start()
    {
        gameManager = GameManager.Instance;


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (ObjectDragInstance3 != null)
        {

            ObjectDragInstance3.transform.position = Input.mousePosition;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameManager.Total >= 250f)
        {
            ObjectDragInstance3 = Instantiate(object_Drag3, canvas.transform);
            ObjectDragInstance3.transform.position = Input.mousePosition;
            ObjectDragInstance3.GetComponent<ObjectDragging>().card3 = this;
            gameManager.draggingObject3 = ObjectDragInstance3;
        }


    }

    public void OnPointerUp(PointerEventData eventData)
    {

        gameManager.PlaceObject4();
        gameManager.draggingObject3 = null;

        Destroy(ObjectDragInstance3);

    }
}

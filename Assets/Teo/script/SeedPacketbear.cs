using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class SeedPacketbear : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag1;
    public GameObject object_game1;
    public Canvas canvas;



    private GameObject ObjectDragInstance1;
    private GameManager gameManager;




    private void Start()
    {
        gameManager = GameManager.Instance;


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (ObjectDragInstance1 != null)
        {
            ObjectDragInstance1.transform.position = Input.mousePosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameManager.Total >= 150f)
        {
            ObjectDragInstance1 = Instantiate(object_Drag1, canvas.transform);
            ObjectDragInstance1.transform.position = Input.mousePosition;
            ObjectDragInstance1.GetComponent<ObjectDragging>().card1 = this;
            gameManager.draggingObject1 = ObjectDragInstance1;
        }


    }

    public void OnPointerUp(PointerEventData eventData)
    {

        gameManager.PlaceObject2();
        gameManager.draggingObject1 = null;

        Destroy(ObjectDragInstance1);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class SeedPacketfireball : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag2;
    public GameObject object_game2;
    public Canvas canvas;



    private GameObject ObjectDragInstance2;
    private GameManager gameManager;




    private void Start()
    {
        gameManager = GameManager.Instance;


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (ObjectDragInstance2 != null)
        {
          
            ObjectDragInstance2.transform.position = Input.mousePosition;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameManager.Total >= 200f)
        {
            ObjectDragInstance2 = Instantiate(object_Drag2, canvas.transform);
            ObjectDragInstance2.transform.position = Input.mousePosition;
            ObjectDragInstance2.GetComponent<ObjectDragging>().card2 = this;
            gameManager.draggingObject2 = ObjectDragInstance2;
        }


    }

    public void OnPointerUp(PointerEventData eventData)
    {

        gameManager.PlaceObject3();
        gameManager.draggingObject2 = null;

        Destroy(ObjectDragInstance2);

    }
}

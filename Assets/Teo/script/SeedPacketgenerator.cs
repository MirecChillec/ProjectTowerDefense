using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SeedPacketgenerator : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject object_Drag;
    public GameObject object_game;
    public Canvas canvas;

    

    public GameObject ObjectDragInstance;
    private GameManager gameManager;
    



    private void Start()
    {
        gameManager = GameManager.Instance;
        

    }
    public void OnDrag(PointerEventData eventData) 
    {
        ObjectDragInstance.transform.position = Input.mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)  
    {
        if (gameManager.Total >= 100f)
        {
            ObjectDragInstance = Instantiate(object_Drag, canvas.transform);
            ObjectDragInstance.transform.position = Input.mousePosition;
            ObjectDragInstance.GetComponent<ObjectDragging>().card = this;

            gameManager.draggingObject = ObjectDragInstance;
        }

         
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
        gameManager.PlaceObject1();
        gameManager.draggingObject = null;
        
        Destroy(ObjectDragInstance);

    }

    
}

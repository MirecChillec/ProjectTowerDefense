using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject draggingObject1;
    public GameObject draggingObject2;
    public GameObject draggingObject3;
    public GameObject currentContainer;
    public static GameManager Instance;
    public int Total;
    public Text text;
    Canvas canvas;
    
    SeedPacketgenerator seedPacket;


    private void Awake()
    {
        
        Instance = this;
        
        Total = 100;
       
    }
    void Update()
    {
        
        text.text = Total.ToString();
    }
    public void PlaceObject1()
    {
        if (draggingObject != null   && currentContainer != null)
        {
            Price(100);
            Instantiate(draggingObject.GetComponent<ObjectDragging>().card.object_game, currentContainer.transform );
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
    public void PlaceObject2()
    {
        if (draggingObject1 != null && currentContainer != null)
        {
            Price(150);
            Instantiate(draggingObject1.GetComponent<ObjectDragging>().card1.object_game1, currentContainer.transform);
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
    public void PlaceObject3()
    {
        if (draggingObject2 != null && currentContainer != null)
        {
            Price(200);
            Instantiate(draggingObject2.GetComponent<ObjectDragging>().card2.object_game2, currentContainer.transform);
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
    public void PlaceObject4()
    {
        if (draggingObject3 != null && currentContainer != null)
        {
            Price(250);
            Instantiate(draggingObject3.GetComponent<ObjectDragging>().card3.object_game3, currentContainer.transform);
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
    public void Price(int cost)
    {
        Total -= cost;
    }
    private void Start()
    {
      
        InvokeRepeating("money", 5, 7);
    }

    void money()
    {

        Total += 100;
    }
}

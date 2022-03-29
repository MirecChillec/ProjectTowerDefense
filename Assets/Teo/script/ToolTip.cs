using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public GameObject tooltip;
    public void Start()
    {
        tooltip.SetActive(false); 
    } 
    public void OnMouseOver()
    {
        tooltip.SetActive(true);
        Debug.Log("Mouse is over GameObject.");


    }
    public void OnMouseExit()
    {
        tooltip.SetActive(false);
    }

}

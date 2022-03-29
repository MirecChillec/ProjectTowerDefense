using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class spawner : MonoBehaviour
{
    public string winScene;
    public bool final;
    public GameObject basicEnemy;
    public GameObject bigEnemy;
    public GameObject stunner;
    public GameObject flyingEnemy;
    
    public Transform spawner1;
    public Transform spawner2;
    public Transform spawner3;
    public Transform spawner4;

    public Canvas canvas;
  
       
    public void Start()
    {
         
        final = false;
        StartCoroutine(waiter());

    }
    

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(8);
       
       
        Instantiate(basicEnemy, canvas.transform);
        
        final = true;
    }

    private void Update()
    {

        

        if (final == true && GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            SceneManager.LoadScene(winScene);
        }
    }







}

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
    
    public Vector3 spawner1;
    public Vector3 spawner2;
    public Vector3 spawner3;
    public Vector3 spawner4;

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
        basicEnemy.transform.position = spawner1;
        yield return new WaitForSeconds(5);
        Instantiate(basicEnemy, canvas.transform);
        
        basicEnemy.transform.position = spawner2;
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

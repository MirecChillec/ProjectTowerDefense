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
        basicEnemy.transform.position = spawner1;
        yield return new WaitForSeconds(8);

        
        Instantiate(basicEnemy, canvas.transform);
        bigEnemy.transform.position = spawner2;
        stunner.transform.position = spawner4;
        flyingEnemy.transform.position = spawner3;
        yield return new WaitForSeconds(5);
        
        Instantiate(bigEnemy, canvas.transform);
        
        Instantiate(stunner, canvas.transform);
        
        Instantiate(flyingEnemy, canvas.transform);
        

        final = true;
    }

    private void Update()
    {

        

        if (final == true && GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            SceneManager.LoadScene(winScene);
        }
    }







}

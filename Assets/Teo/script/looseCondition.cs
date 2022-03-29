using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class looseCondition : MonoBehaviour
{
    public string looseScene;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("lmaoooo");
        SceneManager.LoadScene(looseScene);
    }


}

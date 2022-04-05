using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Enter()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
    }
}

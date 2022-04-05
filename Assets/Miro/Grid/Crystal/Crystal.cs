using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crystal : TowerBase
{
    public bool s100;
    public bool s75;
    public bool s50;
    public bool s25;

    public override void Attack()
    {

    }

    public override void Idle()
    {

    }

    public override void Shoot()
    {

    }

    public void S75()
    {

        ChangeAnimationState("75");
        s75 = true;

    }

    public void S50()
    {

        ChangeAnimationState("50");
    }

    public void S25()
    {
        ChangeAnimationState("25");
    }

    public void Lose()
    {
        ChangeAnimationState("cristal0");
    }

    public void LoseScreen()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(2));
    }

    // Update is called once per frame
    public override void Update()
    {
        if (health <= 0)
        {
            Lose();
        }
        else if (health > 75)
        {
            ChangeAnimationState("100");
        }
        else if (health < 75 && health > 50&&!s75)
        {
            ChangeAnimationState("cristal75");
            s75 = true;
        }
        else if (health < 50 && health > 25&&!s50)
        {
            ChangeAnimationState("cristal50");

            s50 = true;
        }
        else if (health < 25 && health > 1&&s25)
        {
            ChangeAnimationState("cristal25");

            s25 = true;
        }
    }
}

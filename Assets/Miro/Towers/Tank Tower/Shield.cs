using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float currentHealth;
    public int maxHealth = 100;
    public string currentState; 
    public Animator towerAnimator;
    public bool canRecharge = false;
    public SpriteRenderer shieldRenderer;

    public Sprite shield100;
    public Sprite shield75;
    public Sprite shield50;
    public Sprite shield25;

    void Start()
    {
        towerAnimator = GetComponent<Animator>();
        currentHealth = maxHealth;
        ChangeAnimationState("Shield_Animation");
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            //animacia na destruction 
        }
        else if (currentHealth / maxHealth * 100 <= 25)
        {
            shieldRenderer.sprite = shield25;
        }
        else if (currentHealth / maxHealth * 100 <= 50)
        {
            shieldRenderer.sprite = shield50;
        }
        else if (currentHealth / maxHealth * 100 <= 75)
        {
            shieldRenderer.sprite = shield75;
        }
        else if(currentHealth/maxHealth * 100 > 75)
        {
            shieldRenderer.sprite = shield100;
        }

        if (canRecharge && currentHealth < 100)
        {
            currentHealth += 0.5f * Time.deltaTime;
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
    }

    public void Idle()
    {
        ChangeAnimationState("Shield_Idle");
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        towerAnimator.Play(newState);

        currentState = newState;
    }
}

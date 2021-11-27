using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoldBeetle : MonoBehaviour
{
    public Animator animator;
    //public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController goldAnimationController;
    

    public float goldTimer;
    private float currentTimer;

    private void Start()
    {
        currentTimer = goldTimer;
    }

    private void FixedUpdate()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0.0f)
        {
            timerEnded();
            currentTimer = goldTimer;
        }
    }

    private void timerEnded()
    {
        animator.runtimeAnimatorController = goldAnimationController;
    }
}

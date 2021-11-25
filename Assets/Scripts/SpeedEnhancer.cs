using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedEnhancer : MonoBehaviour
{
    public float gameSpeedIncreaseTimer;
    private float currentTimer;

    private void Start()
    {
        currentTimer = gameSpeedIncreaseTimer;
    }

    private void FixedUpdate()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0.0f)
        {
            timerEnded();
            currentTimer = gameSpeedIncreaseTimer;
        }
    }

    private void timerEnded()
    {
        Settings.Instance.GlobalMoveSpeed *= 1.2f;
    }
}

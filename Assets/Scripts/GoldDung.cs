using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoldDung : MonoBehaviour
{
    public Sprite goldDung;
    public Sprite goldDungLighting;

    public SpriteRenderer dung;
    public SpriteRenderer dungLighting;


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
        dung.sprite = goldDung;
        dungLighting.sprite = goldDungLighting;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : SingletonMonobehavior<Timer>
{
    public Text timerText;
    public Text scoreText;
    public Text dungText;



    private float startTime;
    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;
        dungText.text = Settings.Instance.DungTotal.ToString();

        var score = Mathf.Round(t * Settings.Instance.DungTotal);
        scoreText.text = $"Score: {score}";
    }
}

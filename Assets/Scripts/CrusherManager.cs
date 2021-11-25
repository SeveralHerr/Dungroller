using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherManager : MonoBehaviour
{
    public GameObject hand;

    public float summonHandTimer;
    private float currentTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = summonHandTimer;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0.0f)
        {
            var skip = Random.Range(0, 2);
            if (skip == 0)
            {
                timerEnded();
                currentTimer = summonHandTimer;
            }
        }
        
    }

    private void timerEnded()
    {
        Instantiate(hand, transform.position, Quaternion.identity);
    }
}

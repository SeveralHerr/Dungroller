using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherManager : MonoBehaviour
{
    public GameObject hand;

    public float objectTimer;
    private float currentTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = objectTimer;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0.0f)
        {
            // how can we make this a bool instead of an int??
            var skip = Random.Range(0, 1);
            if (skip == 0)
            {
                timerEnded();
                currentTimer = objectTimer;
            }
        }
        
    }

    private void timerEnded()
    {
        Instantiate(hand, transform.position, Quaternion.identity);
    }
}

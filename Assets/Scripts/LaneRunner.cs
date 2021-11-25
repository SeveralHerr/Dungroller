using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneRunner : MonoBehaviour
{
    public List<GameObject> laneObjects;
    public float objectTimer;
    private float currentTimer;

    private void Start()
    {
        currentTimer = objectTimer;
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0.0f)
        {
            var skip = Random.Range(0, 1); 
            if(skip == 0)
            {
                timerEnded();
                currentTimer = objectTimer;
            }
        }
    }

    private void timerEnded()
    {
        var randomLaneObject = Random.Range(0, laneObjects.Count);
        var offset = Random.Range(3f, 119f);
        var position = new Vector3(Constants.LaneStart + offset, transform.position.y + 0.5f);
        Instantiate(laneObjects[randomLaneObject], position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneRunner : MonoBehaviour
{
    public List<GameObject> laneObjects;
    public List<GameObject> lanes;
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
            timerEnded();
            currentTimer = objectTimer;
        }
    }

    private void timerEnded()
    {
        var randomLaneObject = Random.Range(0, laneObjects.Count);
        var randomLane = Random.Range(0, lanes.Count);
        var position = new Vector3(Constants.LaneStart, lanes[randomLane].transform.position.y + 0.5f);
        Instantiate(laneObjects[randomLaneObject], position, Quaternion.identity);
    }
}

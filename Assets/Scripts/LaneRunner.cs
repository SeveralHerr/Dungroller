using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneRunner : MonoBehaviour
{
    public List<GameObject> laneObjects;

    private void Start()
    {
        var item = laneObjects[0];
        var position = new Vector3(Constants.LaneStart, transform.position.y + 0.5f);
        Instantiate(item, position, Quaternion.identity);
    }
}

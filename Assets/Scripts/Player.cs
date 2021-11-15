using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> lanes;
    private int currentLane;

    public GameObject dung;

    private void Start()
    {
        currentLane = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(currentLane < lanes.Count-1)
            {
                currentLane += 1;
                transform.position = new Vector3(transform.position.x, lanes[currentLane].transform.position.y);
                dung.transform.position = new Vector3(dung.transform.position.x, lanes[currentLane].transform.position.y);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentLane > 0)
            {
                currentLane -= 1;
                transform.position = new Vector3(transform.position.x, lanes[currentLane].transform.position.y);
                dung.transform.position = new Vector3(dung.transform.position.x, lanes[currentLane].transform.position.y);
            }
        }
    }
}

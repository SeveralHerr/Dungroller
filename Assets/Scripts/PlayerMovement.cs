using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public List<GameObject> lanes;
    private int currentLane;

    public GameObject dung;
    public GameObject dungCollider;
    private const float horizontalMovement = 1f;

    private void Start()
    {
        currentLane = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (currentLane < lanes.Count - 1)
            {
                currentLane += 1;
                ChangePosition();
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentLane > 0)
            {
                currentLane -= 1;
                ChangePosition();
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            var isOutOfBounds = transform.position.x - horizontalMovement;
            if(isOutOfBounds <= -10.21f)
            {
                return;
            }

            ChangePosition(horizontalMovement * -1);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            var isOutOfBounds = transform.position.x + horizontalMovement;
            if (isOutOfBounds >= 10.17f)
            {
                return;
            }

            ChangePosition(horizontalMovement);
        }
    }

    private Vector3 ChangePosition(Transform transform, float horizontalMovement = 0)
    {
        return new Vector3(transform.position.x + horizontalMovement, lanes[currentLane].transform.position.y);
    }

    private void ChangePosition(float horizontalMovement = 0)
    {
        transform.position = ChangePosition(transform, horizontalMovement);
        dung.transform.position = ChangePosition(dung.transform, horizontalMovement);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungRoller : SingletonMonobehavior<DungRoller>
{
    public int rotation;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    public GameObject dungLighting;


    private float dungRotation = 0;

    public float targetTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
            targetTime = 1f;
        }

        dungRotation -= 0.5f;

        transform.rotation = Quaternion.Euler(Vector3.forward * dungRotation);
        transform.position = new Vector3(player.transform.position.x + 1.3f, transform.position.y);

        dungLighting.transform.position = new Vector3(player.transform.position.x + 1.3f, transform.position.y);
    }

    void timerEnded()
    {

    }

}

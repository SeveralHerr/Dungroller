using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungRoller : MonoBehaviour
{
    public int rotation;

    [SerializeField]
    private GameObject player;

    private Timer timer;
    private int dungRotation = 0;


    // Start is called before the first frame update
    void Start()
    {
        //timer = new Timer(1);
    }

    // Update is called once per frame
    void Update()
    {
        //timer.Tick(Time.deltaTime);
        //if(!timer.IsDone())
        //{

        dungRotation -= 1;

        

        transform.rotation = Quaternion.Euler(Vector3.forward * dungRotation);
        transform.position = new Vector3(player.transform.position.x + 2f, transform.position.y);
            //player.transform.position + new Vector3(player.transform.position.x + 0.05f, player.transform.position.y);
    }
}

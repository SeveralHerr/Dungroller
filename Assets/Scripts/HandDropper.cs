using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDropper : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Vector3 targetlocation;
    public Transform playertransform;

    public GameObject shadow;

    private bool wasHandDown = false;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        targetlocation = playertransform.position;
        var initialhandpos = new Vector3(targetlocation.x + 3, 17);
        transform.position = initialhandpos;

        var shadowPosition = new Vector3(targetlocation.x, targetlocation.y + 1.5f);
        Instantiate(shadow, shadowPosition, Quaternion.identity); 
    }
    private void Update()
    {
        if(transform.position.y <= 3.3f && !wasHandDown)
        {
            wasHandDown = true;
            return;
        }

        if(wasHandDown)
        {
            // fuck you
            var movementSpeed = 0.2f;
            var newPos = new Vector2(transform.position.x , transform.position.y + movementSpeed);
            rigidbody2d.MovePosition(newPos);

            return;
        }

        var newPosition = new Vector2(transform.position.x , transform.position.y -.2f);
        rigidbody2d.MovePosition(newPosition);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Player.Instance.HitPlayer(collision.tag))
        {
            Destroy(shadow.gameObject);
            Player.Instance.DestroyPlayer();
        }
    }
}

//var newPosition = new Vector2(transform.position.x - moveSpeed, transform.position.y);
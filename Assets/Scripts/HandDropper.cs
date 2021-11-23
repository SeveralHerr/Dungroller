using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class HandDropper : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Vector3 targetlocation;

    public GameObject shadow;

    private bool wasHandDown = false;

    void Start()
    {
        if (Player.Instance.Position() == null)
        {
            Destroy(gameObject);
        }

        rigidbody2d = GetComponent<Rigidbody2D>();
        targetlocation = Player.Instance.Position().GetValueOrDefault();

        var initialhandpos = new Vector3(targetlocation.x + 0.5f, 17);
        transform.position = initialhandpos;

        var shadowPosition = new Vector3(targetlocation.x, -0.38f);
        Instantiate(shadow, shadowPosition, Quaternion.identity); 
    }
    private void Update()
    {
        if (transform.position.y <= 3.35f && !wasHandDown)
        {
            wasHandDown = true;
            return;
        }

        if (wasHandDown)
        {
            // fuck you
            var movementSpeed = 0.2f;
            var newPos = new Vector2(transform.position.x, transform.position.y + movementSpeed);
            rigidbody2d.MovePosition(newPos);

            if (rigidbody2d.position.y >= 17 && wasHandDown)
            {
                var shdw = GameObject.FindGameObjectWithTag("Shadow");
                Destroy(shdw);
                Destroy(gameObject);
            }

            return;
        }
       
        var newPosition = new Vector2(transform.position.x, transform.position.y - .2f);
        rigidbody2d.MovePosition(newPosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Player.Instance.HitPlayer(collision.tag))
        {
           
            Player.Instance.DestroyPlayer();
        }
    }
}

//var newPosition = new Vector2(transform.position.x - moveSpeed, transform.position.y);
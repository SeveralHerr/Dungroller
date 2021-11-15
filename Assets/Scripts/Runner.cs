using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float moveSpeed = .001f;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        var newPosition = new Vector2(transform.position.x - moveSpeed, transform.position.y);
        rigidbody2d.MovePosition(newPosition);

        if (transform.position.x <= Constants.LaneEnd)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            var playerGroup = GameObject.FindGameObjectsWithTag("Player");
            foreach(var item in playerGroup)
            {
                Destroy(item.gameObject);
            }
        }

        Destroy(gameObject);
    }
}

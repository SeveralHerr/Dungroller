using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float moveSpeed = .001f;
    public bool isScenery = false;
    public bool isAddsToPoop = false;

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
        if(isScenery)
        {
            return;
        }

        if(isAddsToPoop)
        {
            var scale = DungRoller.Instance.transform.localScale;
            var newScale = new Vector3(scale.x + 0.03f, scale.y + 0.03f, scale.z + 0.03f);
            DungRoller.Instance.transform.localScale = newScale;

            Destroy(gameObject);
            return;
        }

        if (Player.Instance.HitPlayer(collision.tag))
        {
            Player.Instance.DestroyPlayer();
        }

        Destroy(gameObject);
    }
}

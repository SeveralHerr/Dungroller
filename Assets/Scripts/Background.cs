using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public GameObject background;
    private bool hasMadeNewBackground = false;
    public float speedModifier = 1;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        var newPosition = new Vector2(transform.position.x - (Settings.Instance.GlobalMoveSpeed * speedModifier), transform.position.y);
        rigidbody2d.MovePosition(newPosition);

        if (transform.position.x <= -8 && !hasMadeNewBackground)
        {
            var newBackgroundPosition = new Vector2(31, transform.position.y);
            Transform parent;

            if (gameObject.transform.tag == "Lane")
            {
                parent = GameObject.FindGameObjectWithTag("Lane").transform;
                Instantiate(background, newBackgroundPosition, Quaternion.identity, parent);
            }
            else
            {
                Instantiate(background, newBackgroundPosition, Quaternion.identity);
            }


            hasMadeNewBackground = true;

        }

        if (transform.position.x <= -33 )
        {
            Destroy(gameObject);
        }
    }
}

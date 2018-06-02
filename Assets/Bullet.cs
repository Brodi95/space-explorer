using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private const float maxDistance = 4f;
    private const float speed = 5f;

    public Vector2 startPos;
    private Vector2 direction;
    private Rigidbody2D rb;
    private bool shoot;

    public Vector2 Direction
    {
        get
        {
            return direction;
        }

        set
        {
            direction = value;
            shoot = true;
        }
    }

<<<<<<< HEAD
    private void Awake()
    {
        startPos = transform.position;
    }

=======
>>>>>>> 37ef3f063cd3d1484d836f2865d671d671ed97e4
    private void FixedUpdate()
    {
        if (!shoot)
            return;

        if (Vector2.Distance(startPos, transform.position) >= maxDistance)
        {
            Debug.Log("die");
            Destroy(gameObject);
        }

        Vector3 moveDirection = Direction * speed * Time.fixedDeltaTime;
        transform.position += moveDirection;
    }

<<<<<<< HEAD
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == gameObject)
            return;

        if(collision.tag == "Alien")
        {
            Debug.Log("Do damage to alien");
            return;
        }
        
    }
=======
>>>>>>> 37ef3f063cd3d1484d836f2865d671d671ed97e4
}

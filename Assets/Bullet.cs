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

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;

    float horizontal;
    float vertical;

    private Player player;
    private bool movePlayer;

    private void Start()
    {
        player = Player.player;
        player.FlipCharacter += Flip;
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if(horizontal != 0 || vertical != 0)
        {
            movePlayer = true;
        }
    }

    void FixedUpdate () {
        // Get Player input


        if (!movePlayer)
            return;

        movePlayer = false;

        // Flip the player if he is facing right but moving left
        if((horizontal < 0 && player.facingRight) || (horizontal > 0 && !player.facingRight)) {
            player.FlipCharacter();
        }

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0f);
        moveDirection = moveDirection * Speed * Time.deltaTime;
        transform.position += moveDirection;
	}

    void Flip()
    {
        player.facingRight = !player.facingRight;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}

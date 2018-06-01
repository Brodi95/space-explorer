using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;

    private bool facingRight = false;

    private Player player;

    private void Start()
    {
        player = Player.player;
        player.FlipCharacter += Flip;
    }

    void Update () {
        // Get Player input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Flip the player if he is facing right but moving left
        if((horizontal < 0 && facingRight) || (horizontal > 0 && !facingRight)) {
            player.FlipCharacter();
        }

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0f);
        moveDirection = moveDirection * Speed * Time.deltaTime;
        transform.position += moveDirection;
	}

    void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if(x == 0 && y == 0)
        {
            x = Player.player.facingRight ? 1 : -1;
        }


        var bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();

        bullet.Direction = new Vector2(x, y);
    }
}

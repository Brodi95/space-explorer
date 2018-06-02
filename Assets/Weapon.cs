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

<<<<<<< HEAD
        var bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
=======
        var bullet = Instantiate(BulletPrefab).GetComponent<Bullet>();
        bullet.startPos = transform.position;
>>>>>>> 37ef3f063cd3d1484d836f2865d671d671ed97e4
        bullet.Direction = new Vector2(x, y);
    }
}

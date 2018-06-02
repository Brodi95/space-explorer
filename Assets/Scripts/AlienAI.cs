using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAI : MonoBehaviour {
    public float speed;
    public GameObject Hunted;
    public SpriteRenderer renderer;
    public Color angry;
    public Color chill;
    private float fireRate = 1;
    private bool canFire = true;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (!canFire)
        {
            fireRate -= Time.fixedDeltaTime;
            if (fireRate <= 0)
            {
                canFire = true;
            }
        }
        if (Hunted != null)
        {
            transform.Translate(((Hunted.transform.position - transform.position).normalized) * speed * Time.fixedDeltaTime,Space.World);
            if (canFire)
            {
                if ((Hunted.transform.position - transform.position).magnitude < 3)
                {
                    renderer.color = angry;
                    canFire = false;
                }
                else
                {
                    renderer.color = chill;
                    GetComponent<AlienAttacks>().SpitAttack(Hunted);
                    canFire = false;
                    fireRate = 1.5f;
                } 
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            // run towards player
            Hunted = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Hunted = null;
        }

    }

}


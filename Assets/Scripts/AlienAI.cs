using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAI : MonoBehaviour {
    public float speed;
    public GameObject Hunted;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Hunted != null)
        {
            transform.Translate(((Hunted.transform.position - transform.position).normalized) * speed * Time.fixedDeltaTime);

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


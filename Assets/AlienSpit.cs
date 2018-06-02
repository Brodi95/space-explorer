using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpit : MonoBehaviour {

    
    public void Fire(Vector2 direction,float power)
    {
        GetComponent<Rigidbody2D>().AddForce(direction * power, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Alien")
        {
            Destroy(gameObject); 
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRing : MonoBehaviour {
    public float growthSpeed;
    
	// Use this for initialization
	void Start () {

        StartCoroutine(Death());
    }
	
	// Update is called once per frame
	void Update () {
        transform.localScale *= growthSpeed;
	}

    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);

        Destroy(gameObject);
        
    }

    

}

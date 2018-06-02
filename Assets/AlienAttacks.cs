using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAttacks : MonoBehaviour {

    [Header("Attacks")]
    public GameObject fireRing;
    public GameObject alienSpit;
    

    public void FireAttack(GameObject target)
    {
        Instantiate(fireRing, transform.position, Quaternion.identity);
    }

    public void SpitAttack(GameObject target)
    {
        GameObject temp = Instantiate(alienSpit, transform.position, Quaternion.identity);
        temp.GetComponent<AlienSpit>().Fire(target.transform.position - transform.position, 2);
    }


}

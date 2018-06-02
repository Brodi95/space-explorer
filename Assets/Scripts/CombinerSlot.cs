using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinerSlot : MonoBehaviour {

    private GameObject Item;
    public PlayerInventory inv;
    public void DropItem(GameObject _item)
    {
        if (Item != null)
        {

            Item.transform.parent = PlayerInventory.inv.FindFirstFreeSlot().transform;
            Item.transform.localPosition = Vector3.zero;
        }
        Item = _item;
        Item.transform.parent = transform;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public ItemTemplate item;



    public void Interact()
    {
        PlayerInventory.inv.FindFirstFreeSlot().AddItem(item);
        Destroy(gameObject);
    }
}

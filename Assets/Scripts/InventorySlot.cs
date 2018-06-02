using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour {
    public GameObject item;
    public GameObject slot;
    public int amount;

	public void AddItem(GameObject _item)
    {
        if (item == null)
        {
            item = _item;
            Instantiate(item,transform);
            amount = 1;
        }
        else if (item = _item)
        {
            amount++;
        }

    }
    public void RemoveItem()
    {
        if (amount > 0)
        {
            amount--;
        }
        else
        {
            Destroy(item);
        }
    }
    private void updateUI()
    {
        
    }

    
    
}

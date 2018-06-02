using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour {
    private GameObject item;
    public GameObject slot;
    public GameObject itemPrefab;
    public int amount;

	public void AddItem(ItemTemplate _itemSO)
    {
        item = Instantiate(itemPrefab) as GameObject;
        item.GetComponent<ItemInfo>().Instantiate(_itemSO);
        item.transform.parent = transform;
        item.transform.localPosition = Vector3.zero;
        

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

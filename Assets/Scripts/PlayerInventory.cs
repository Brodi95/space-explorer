using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    public static PlayerInventory inv;
    public GameObject slotGO;

    private int inventorySize = 24;
    public ItemTemplate stone;
    public GameObject[] Inventory;

	// Use this for initialization
	void Start () {
        inv = this;
        Inventory = new GameObject[inventorySize];
        int slotCount = 0;
        foreach (GameObject item in Inventory)
        {

            GameObject tempSlot = Instantiate(slotGO) as GameObject;
            tempSlot.transform.parent = transform;

            Inventory[slotCount] = tempSlot;
            slotCount++;
            
        }

        FindFirstFreeSlot().AddItem(stone);
       
       
       

    }
	public InventorySlot FindFirstFreeSlot()
    {
        int slotCount = 0;
        foreach (var item in Inventory)
        {
            Debug.Log(Inventory[slotCount].transform.childCount);
            if (Inventory[slotCount].transform.childCount == 0)
            {
                Debug.Log("empty slot found "+slotCount);
                return Inventory[slotCount].GetComponent<InventorySlot>();
            }
            slotCount++;
        }
        Debug.Log("no empty slot found");
        return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
    
}

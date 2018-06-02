using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour,IDropHandler {
    public ItemDragHandler idh;

    private GameObject Slot_A;
    private GameObject Slot_B;
    private GameObject Inventory;
    public void OnDrop(PointerEventData eventData)
    {
        
        RectTransform Slot_A_Rect = Slot_A.transform as RectTransform;
        RectTransform Slot_B_Rect = Slot_B.transform as RectTransform;
        RectTransform Inventory_Rect = Inventory.transform as RectTransform;
        if (RectTransformUtility.RectangleContainsScreenPoint(Slot_A_Rect,Input.mousePosition))
        {
            Debug.Log("Found a");
            Slot_A.GetComponent<CombinerSlot>().DropItem(this.gameObject);
        }
        else if (RectTransformUtility.RectangleContainsScreenPoint(Slot_B_Rect, Input.mousePosition))
        {
            Slot_B.GetComponent<CombinerSlot>().DropItem(this.gameObject);
        }
        else if (RectTransformUtility.RectangleContainsScreenPoint(Inventory_Rect, Input.mousePosition))
        {
            Debug.Log("found inventory");
            InventorySlot freeSlot = PlayerInventory.inv.FindFirstFreeSlot();
            this.gameObject.transform.parent = freeSlot.transform;
            transform.localPosition = Vector3.zero;
        }
        else
        {
            Debug.Log("nothing to drop on");
            transform.parent = idh.formerParent;
        }
    }

    // Use this for initialization
    void Start ()
    {
        Slot_A = GameObject.Find("Slot_A");
        Slot_B = GameObject.Find("Slot_B");
        Inventory = GameObject.Find("Inventory");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

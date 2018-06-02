using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour,IDropHandler {

    private GameObject Slot_A;
    private GameObject Slot_B;
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform Slot_A_Rect = Slot_A.transform as RectTransform;
        RectTransform Slot_B_Rect = Slot_B.transform as RectTransform;
        if (RectTransformUtility.RectangleContainsScreenPoint(Slot_A_Rect,Input.mousePosition))
        {
            Slot_A.GetComponent<CombinerSlot>().DropItem(this.gameObject);
        }
        else if (RectTransformUtility.RectangleContainsScreenPoint(Slot_B_Rect, Input.mousePosition))
        {
            Slot_B.GetComponent<CombinerSlot>().DropItem(this.gameObject);
        }
        else
        {
            Debug.Log("Did not found Slot");
        }
    }

    // Use this for initialization
    void Start ()
    {
        Slot_A = GameObject.Find("Slot_A");
        Slot_B = GameObject.Find("Slot_B");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

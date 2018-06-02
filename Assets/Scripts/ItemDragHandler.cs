using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDragHandler : MonoBehaviour, IDragHandler,IEndDragHandler
{
    public GameObject CraftingSystem;
    public Vector3 defaultPosition;
    public Transform formerParent;
    bool setOnThisDrag = false;

    public void OnDrag(PointerEventData eventData)
    {
        setFormerParent();
        Debug.Log("Dragging");
        transform.parent = CraftingSystem.transform;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100);
        transform.position = mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end Drag");
        
        transform.localPosition = Vector3.zero;
        setOnThisDrag = false;
    }

    private void setFormerParent()
    {

        if(setOnThisDrag == false)

    {
            formerParent = transform.parent;
            setOnThisDrag = true; 
        }
    }

    // Use this for initialization
    void Start ()
    {
        CraftingSystem = GameObject.Find("CraftingSystem");
        defaultPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

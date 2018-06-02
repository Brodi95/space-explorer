using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDragHandler : MonoBehaviour, IDragHandler,IEndDragHandler
{
    public Vector3 defaultPosition;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
    }



    // Use this for initialization
    void Start ()
    {
        defaultPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

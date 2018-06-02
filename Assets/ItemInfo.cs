using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour {
    public ItemTemplate Item;
    public Image img;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Instantiate(ItemTemplate _itemSO)
    {
        Item = _itemSO;
        img.sprite = Item.image;
    }
}

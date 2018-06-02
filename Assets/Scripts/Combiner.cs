using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combiner : MonoBehaviour {

    public GameObject Slot_A;
    public GameObject Slot_B;
    public List<ItemTemplate> Recipes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public ItemTemplate CheckRecipes()
    {
        if (Slot_A.transform.childCount != 0 && Slot_B.transform.childCount != 0)
        {
            ItemTemplate A = Slot_A.transform.GetChild(0).GetComponent<ItemTemplate>();
            ItemTemplate B = Slot_B.transform.GetChild(0).GetComponent<ItemTemplate>();
            foreach (var recipe in Recipes)
            {
                if (recipe.recipe1 == A && recipe.recipe2 == B)
                {
                    return recipe;
                }
            }
            return null;
        }
    }
}

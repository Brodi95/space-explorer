using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combiner : MonoBehaviour {

    public GameObject Slot_A;
    public GameObject Slot_B;
    public GameObject Slot_C;
    public GameObject ItemPrefeb;
    public List<ItemTemplate> Recipes;

	
    public void Combine()
    {
        if (Slot_A.transform.childCount > 1 && Slot_B.transform.childCount > 1)
        {
            ItemTemplate Result = CheckRecipes();
            if (Result != null)
            {
                Instantiate(ItemPrefeb) as GameObject;
            }
        }
    }
    public ItemTemplate CheckRecipes()
    {
        
        ItemTemplate A = Slot_A.transform.GetChild(1).GetComponent<ItemTemplate>();
        ItemTemplate B = Slot_B.transform.GetChild(1).GetComponent<ItemTemplate>();
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

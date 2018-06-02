using UnityEngine;
[CreateAssetMenu(fileName ="New Item",menuName ="Item")]
public class ItemTemplate : ScriptableObject{


    public new string name;
    public string description;

    public Sprite image;

    public ItemTemplate recipe1;
    public ItemTemplate recipe2;

    
}

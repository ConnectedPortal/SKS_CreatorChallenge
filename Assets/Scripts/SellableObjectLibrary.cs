using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/SellableObject", order = 1)]
public class SellableObjectLibrary : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public int itemCost;
    public string itemDescription;
}

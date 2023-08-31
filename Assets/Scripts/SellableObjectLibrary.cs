using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SellableObject", order = 1)]
public class SellableObjectLibrary : ScriptableObject
{
    public string itemName;
    public Image itemSprite;
    public int itemCost;
    public string itemDescription;
}

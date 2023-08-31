using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private ShopManager itemManager;
    [SerializeField] private Image itemAnchor;
    public SellableObjectLibrary item;

    private bool beenSold = false;
    [SerializeField] GameObject sellableItem;

    private void Start()
    {
        itemAnchor.sprite = item.itemSprite;
        Debug.Log(item.itemName);
    }

    public void HasBeenSold()
    {
        beenSold = true;
        sellableItem.SetActive(false);
    }

    public void ItemSelected()
    {
        itemManager.SelectObject(sellableItem);
        Debug.Log("Item Selected: " + sellableItem.name);
    }
}

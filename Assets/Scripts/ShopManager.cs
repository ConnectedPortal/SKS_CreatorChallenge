using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameObject selectedObject;
    [SerializeField] private MoneyAdder playerMoney;
    [SerializeField] private ItemDisplay itemInfo;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private TMP_Text moneyText;

    public void CashUpdate()
    {
        moneyText.SetText("Cash: " + playerMoney.money.ToString());
    }

    public void SelectObject(GameObject item)
    {
        selectedObject = item;
        itemInfo = item.GetComponent<ItemDisplay>();
        InspectItemDialogue();
    }

    public void InspectItemDialogue()
    {
        if (selectedObject != null)
        {
            dialogueText.SetText(itemInfo.item.itemName + "\nCost: " + itemInfo.item.itemCost + "\n" + itemInfo.item.itemDescription);
        }
    }

    public void ItemPurchase()
    {
        if (itemInfo.item.itemCost < playerMoney.money)
        {
            itemInfo.HasBeenSold();

            playerMoney.ItemPurchase(itemInfo.item.itemCost);

            dialogueText.SetText("Thanks for the cash!");
        }
        else
        {
            dialogueText.SetText("Sorry, Bub. Come back when you're a little richer!");
        }
    }
}

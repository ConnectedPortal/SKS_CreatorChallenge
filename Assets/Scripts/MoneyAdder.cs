using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAdder : MonoBehaviour
{
    [SerializeField] private ShopManager moneyInfo;
    public int money = 100;

    private void Start()
    {
        moneyInfo.CashUpdate();
    }

    public void ItemPurchase(int price)
    {
        money -= price;
        moneyInfo.CashUpdate();
    }

    public void GainMoney(int moneyAmount)
    {
        money += moneyAmount;
        moneyInfo.CashUpdate();
    }
}

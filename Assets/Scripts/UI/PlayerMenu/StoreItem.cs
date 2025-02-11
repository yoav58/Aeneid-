using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreItem : MonoBehaviour
{

    public string ItemName;
    public int itemCost;
    public GoldManager gm;
    public ItemsManager itm;
    public TMP_Text itemCostText;
    public string DiscountName;
    public int DiscountDivider;
    public 
    // Start is called before the first frame update
    void Start()
    {
        //if (PlayerPrefs.GetInt(DiscountName) == 1) CostDiscount(DiscountDivider);
        //itemCostText.text = itemCost.ToString();
    }

    private void OnEnable()
    {
        if (PlayerPrefs.GetInt(DiscountName) == 1) CostDiscount(DiscountDivider);
        itemCostText.text = itemCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /******************************************************************
    * Function Name: buyItem
    *Description: eachStore should have this on each item.
    *****************************************************************/
    public void buyItem()
    {
        int currentAmountOfCoins = gm.getAmountOfCoins();
        if (currentAmountOfCoins < itemCost) return; // if not enugh coins.
        itm.addItem(this.ItemName);
        gm.removePoints(itemCost);
    }

    public void CostDiscount(int divider)
    {
        itemCost = itemCost / divider;
        itemCostText.text = itemCost.ToString();
    }
}

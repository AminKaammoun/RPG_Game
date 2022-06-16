using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionShopBuyButtons : MonoBehaviour
{
    public InventoryObject inventory;
    public ItemObject smallHealthPotion;
    public ItemObject bigHealthPotion;
    public void smallPotionBuy()
    {

        inventory.AddItem(smallHealthPotion, 1);
        inventory.save();

    }
    public void bigPotionBuy()
    {

        inventory.AddItem(bigHealthPotion, 1);
        inventory.save();
    }


}

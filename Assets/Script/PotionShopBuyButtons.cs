using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionShopBuyButtons : MonoBehaviour
{
    public InventoryObject inventory;
    public ItemObject smallHealthPotion;
    public ItemObject bigHealthPotion;
    public ItemObject smallSheildPotion;
    public ItemObject bigSheildPotion;
    public ItemObject smallSpeedPotion;
    public ItemObject bigSpeedPotion;

    public void smallHealthPotionBuy()
    {

        inventory.AddItem(smallHealthPotion, 1);
        inventory.save();

    }
    public void bigHealthPotionBuy()
    {

        inventory.AddItem(bigHealthPotion, 1);
        inventory.save();
    }
    public void smallSheildPotionBuy()
    {
        inventory.AddItem(smallSheildPotion, 1);
        inventory.save();
    }
    public void bigSheildPotionBuy()
    {
        inventory.AddItem(bigSheildPotion, 1);
        inventory.save();
    }
    public void smallSpeedPotionBuy()
    {
        inventory.AddItem(smallSpeedPotion, 1);
        inventory.save();
    }
    public void bigSpeedPotionBuy()
    {
        inventory.AddItem(bigSpeedPotion, 1);
        inventory.save();
    }
}
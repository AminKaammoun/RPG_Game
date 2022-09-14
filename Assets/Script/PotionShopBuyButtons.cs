using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionShopBuyButtons : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject potionsInventory;

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

        potionsInventory.AddItem(smallHealthPotion, 1);
        potionsInventory.save();

    }
    public void bigHealthPotionBuy()
    {

        inventory.AddItem(bigHealthPotion, 1);
        inventory.save();

        potionsInventory.AddItem(bigHealthPotion, 1);
        potionsInventory.save();
    }
    public void smallSheildPotionBuy()
    {
        inventory.AddItem(smallSheildPotion, 1);
        inventory.save();

        potionsInventory.AddItem(smallSheildPotion, 1);
        potionsInventory.save();
    }
    public void bigSheildPotionBuy()
    {
        inventory.AddItem(bigSheildPotion, 1);
        inventory.save();

        potionsInventory.AddItem(bigSheildPotion, 1);
        potionsInventory.save();
    }
    public void smallSpeedPotionBuy()
    {
        inventory.AddItem(smallSpeedPotion, 1);
        inventory.save();

        potionsInventory.AddItem(smallSpeedPotion, 1);
        potionsInventory.save();
    }
    public void bigSpeedPotionBuy()
    {
        inventory.AddItem(bigSpeedPotion, 1);
        inventory.save();

        potionsInventory.AddItem(bigSpeedPotion, 1);
        potionsInventory.save();
    }
}
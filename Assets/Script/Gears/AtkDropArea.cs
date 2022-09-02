using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AtkDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;

    public ItemObject lvl1RedGem;
    public ItemObject lvl1BlueGem;
    public ItemObject lvl1YellowGem;
    public ItemObject lvl1OrangeGem;
    public ItemObject lvl1GreenGem;

    // public GameObject Gear;
    public static int num;

    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {

            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("attack"))
            {
                //GameController.wantToSwapGears = true;

                if (GameController.swapGems)
                {

                    if (GameController.attackGear == "lvl 1 attack (equipmentObject)")
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 5;

                    }
                    else if (GameController.attackGear == "lvl 10 attack (equipmentObject)")
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 50;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 25;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    }
                }
                else
                {
                    switch (GameController.swordRedGem)
                    {
                        case "lvl1RedGem (gemObject)":
                            inventory.AddItem(lvl1RedGem, 1);
                            GemInventory.AddItem(lvl1RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.swordRedGem = "";
                            PlayerMovements.BonusAttack -= 5;
                            break;
                    }

                    switch (GameController.swordBlueGem)
                    {
                        case "lvl1BlueGem (gemObject)":
                            inventory.AddItem(lvl1BlueGem, 1);
                            GemInventory.AddItem(lvl1BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.swordBlueGem = "";
                            PlayerMovements.BonusDefence -= 5;
                            break;
                    }


                    switch (GameController.swordYellowGem)
                    {
                        case "lvl1YellowGem (gemObject)":
                            inventory.AddItem(lvl1YellowGem, 1);
                            GemInventory.AddItem(lvl1YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.swordYellowGem = "";
                            PlayerMovements.BonusAgility -= 5;
                            break;
                    }

                    switch (GameController.swordOrangeGem)
                    {
                        case "lvl1OrangeGem (gemObject)":
                            inventory.AddItem(lvl1OrangeGem, 1);
                            GemInventory.AddItem(lvl1OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.swordOrangeGem = "";
                            PlayerMovements.BonusSp -= 5;
                            break;
                    }


                    switch (GameController.swordGreenGem)
                    {
                        case "lvl1GreenGem (gemObject)":
                            inventory.AddItem(lvl1GreenGem, 1);
                            GemInventory.AddItem(lvl1GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.swordGreenGem = "";
                            PlayerMovements.BonusHp -= 25;
                            break;
                    }

                    if (GameController.attackGear == "lvl 1 attack (equipmentObject)")
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 5;

                    }
                    else if (GameController.attackGear == "lvl 10 attack (equipmentObject)")
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 50;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 25;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    }

                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }


                if (GameController.attackGear == "lvl 1 attack (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (GameController.attackGear == "lvl 10 attack (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 attack inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 attack inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        GameController.attackGear = itemObject[0].ToString();
                        break;
                    case 1:
                        GameController.attackGear = itemObject[1].ToString();

                        break;

                }
                LapidaryLeftSide.refresh = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();

                AttackGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

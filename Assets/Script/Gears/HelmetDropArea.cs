using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelmetDropArea : MonoBehaviour, IDropHandler
{

    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;

    public static int num;

    public ItemObject lvl1RedGem;
    public ItemObject lvl1BlueGem;
    public ItemObject lvl1YellowGem;
    public ItemObject lvl1OrangeGem;
    public ItemObject lvl1GreenGem;

    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {
           
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("helmet"))
            {

                if (GameController.swapGems)
                {
                    switch (GameController.helmetGear)
                    {
                        case "lvl 1 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 4;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 8;
                            break;
                        case "lvl 10 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 50;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 40;
                            break;
                    }
                }
                else
                {
                    switch (GameController.helmetRedGem)
                    {
                        case "lvl1RedGem (gemObject)":
                            inventory.AddItem(lvl1RedGem, 1);
                            GemInventory.AddItem(lvl1RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetRedGem = "";
                            PlayerMovements.BonusAttack -= 5;
                            break;
                    }

                    switch (GameController.helmetBlueGem)
                    {
                        case "lvl1BlueGem (gemObject)":
                            inventory.AddItem(lvl1BlueGem, 1);
                            GemInventory.AddItem(lvl1BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetBlueGem = "";
                            PlayerMovements.BonusDefence -= 5;
                            break;
                    }


                    switch (GameController.helmetYellowGem)
                    {
                        case "lvl1YellowGem (gemObject)":
                            inventory.AddItem(lvl1YellowGem, 1);
                            GemInventory.AddItem(lvl1YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetYellowGem = "";
                            PlayerMovements.BonusAgility -= 5;
                            break;
                    }

                    switch (GameController.helmetOrangeGem)
                    {
                        case "lvl1OrangeGem (gemObject)":
                            inventory.AddItem(lvl1OrangeGem, 1);
                            GemInventory.AddItem(lvl1OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetOrangeGem = "";
                            PlayerMovements.BonusSp -= 5;
                            break;
                    }


                    switch (GameController.helmetGreenGem)
                    {
                        case "lvl1GreenGem (gemObject)":
                            inventory.AddItem(lvl1GreenGem, 1);
                            GemInventory.AddItem(lvl1GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetGreenGem = "";
                            PlayerMovements.BonusHp -= 25;
                            break;
                    }
                    switch (GameController.helmetGear)
                    {
                        case "lvl 1 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 4;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 8;
                            break;
                        case "lvl 10 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 50;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 40;
                            break;
                    }
                   
                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                
                if (GameController.helmetGear == "lvl 1 helmet (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (GameController.helmetGear == "lvl 10 helmet (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 helmet inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 helmet inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        GameController.helmetGear = itemObject[0].ToString();
                        break;
                    case 1:
                        GameController.helmetGear = itemObject[1].ToString();

                        break;

                }
                //Debug.Log(PlayerPrefs.GetString("AttackGear"));
                //Debug.Log(itemObject.ToString());
                //AtkLevel1.destoryItem = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();
                LapidaryLeftSide.refresh = true;
                //Inventory.refreshInv = true;
                //InvDraggableComponent.isPlaced = true;
                HelmetGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}
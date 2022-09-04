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
    
    public ItemObject lvl2RedGem;
    public ItemObject lvl2BlueGem;
    public ItemObject lvl2YellowGem;
    public ItemObject lvl2OrangeGem;
    public ItemObject lvl2GreenGem;

    public ItemObject lvl3RedGem;
    public ItemObject lvl3BlueGem;
    public ItemObject lvl3YellowGem;
    public ItemObject lvl3OrangeGem;
    public ItemObject lvl3GreenGem;

    public ItemObject lvl4RedGem;
    public ItemObject lvl4BlueGem;
    public ItemObject lvl4YellowGem;
    public ItemObject lvl4OrangeGem;
    public ItemObject lvl4GreenGem;

    public ItemObject lvl5RedGem;
    public ItemObject lvl5BlueGem;
    public ItemObject lvl5YellowGem;
    public ItemObject lvl5OrangeGem;
    public ItemObject lvl5GreenGem;

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
                            GameController.gearExist = true;
                            break;
                        case "lvl 10 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 50;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 40;
                            GameController.gearExist = true;
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
                            GameController.helmetAtkGemBonus = 0;
                            break;

                        case "lvl2RedGem (gemObject)":

                            inventory.AddItem(lvl2RedGem, 1);
                            GemInventory.AddItem(lvl2RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetRedGem = "";
                            PlayerMovements.BonusAttack -= 15;
                            GameController.helmetAtkGemBonus = 0;
                            break;

                        case "lvl3RedGem (gemObject)":

                            inventory.AddItem(lvl3RedGem, 1);
                            GemInventory.AddItem(lvl3RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetRedGem = "";
                            PlayerMovements.BonusAttack -= 45;
                            GameController.helmetAtkGemBonus = 0;
                            break;

                        case "lvl4RedGem (gemObject)":

                            inventory.AddItem(lvl4RedGem, 1);
                            GemInventory.AddItem(lvl4RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetRedGem = "";
                            PlayerMovements.BonusAttack -= 135;
                            GameController.helmetAtkGemBonus = 0;
                            break;

                        case "lvl5RedGem (gemObject)":

                            inventory.AddItem(lvl5RedGem, 1);
                            GemInventory.AddItem(lvl5RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetRedGem = "";
                            PlayerMovements.BonusAttack -= 405;
                            GameController.helmetAtkGemBonus = 0;
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
                            GameController.helmetDefGemBonus = 0;
                            break;

                        case "lvl2BlueGem (gemObject)":
                            inventory.AddItem(lvl2BlueGem, 1);
                            GemInventory.AddItem(lvl2BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetBlueGem = "";
                            PlayerMovements.BonusDefence -= 15;
                            GameController.helmetDefGemBonus = 0;
                            break;

                        case "lvl3BlueGem (gemObject)":
                            inventory.AddItem(lvl3BlueGem, 1);
                            GemInventory.AddItem(lvl3BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetBlueGem = "";
                            PlayerMovements.BonusDefence -= 45;
                            GameController.helmetDefGemBonus = 0;
                            break;

                        case "lvl4BlueGem (gemObject)":
                            inventory.AddItem(lvl4BlueGem, 1);
                            GemInventory.AddItem(lvl4BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetBlueGem = "";
                            PlayerMovements.BonusDefence -= 135;
                            GameController.helmetDefGemBonus = 0;
                            break;

                        case "lvl5BlueGem (gemObject)":
                            inventory.AddItem(lvl5BlueGem, 1);
                            GemInventory.AddItem(lvl5BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetBlueGem = "";
                            PlayerMovements.BonusDefence -= 405;
                            GameController.helmetDefGemBonus = 0;
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
                            GameController.helmetAgiGemBonus = 0;
                            break;

                        case "lvl2YellowGem (gemObject)":
                            inventory.AddItem(lvl2YellowGem, 1);
                            GemInventory.AddItem(lvl2YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetYellowGem = "";
                            PlayerMovements.BonusAgility -= 15;
                            GameController.helmetAgiGemBonus = 0;
                            break;

                        case "lvl3YellowGem (gemObject)":
                            inventory.AddItem(lvl3YellowGem, 1);
                            GemInventory.AddItem(lvl3YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetYellowGem = "";
                            PlayerMovements.BonusAgility -= 45;
                            GameController.helmetAgiGemBonus = 0;
                            break;

                        case "lvl4YellowGem (gemObject)":
                            inventory.AddItem(lvl4YellowGem, 1);
                            GemInventory.AddItem(lvl4YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetYellowGem = "";
                            PlayerMovements.BonusAgility -= 135;
                            GameController.helmetAgiGemBonus = 0;
                            break;

                        case "lvl5YellowGem (gemObject)":
                            inventory.AddItem(lvl5YellowGem, 1);
                            GemInventory.AddItem(lvl5YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetYellowGem = "";
                            PlayerMovements.BonusAgility -= 405;
                            GameController.helmetAgiGemBonus = 0;
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
                            GameController.helmetSpGemBonus = 0;
                            break;

                        case "lvl2OrangeGem (gemObject)":
                            inventory.AddItem(lvl2OrangeGem, 1);
                            GemInventory.AddItem(lvl2OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetOrangeGem = "";
                            PlayerMovements.BonusSp -= 15;
                            GameController.helmetSpGemBonus = 0;
                            break;

                        case "lvl3OrangeGem (gemObject)":
                            inventory.AddItem(lvl3OrangeGem, 1);
                            GemInventory.AddItem(lvl3OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetOrangeGem = "";
                            PlayerMovements.BonusSp -= 45;
                            GameController.helmetSpGemBonus = 0;
                            break;

                        case "lvl4OrangeGem (gemObject)":
                            inventory.AddItem(lvl4OrangeGem, 1);
                            GemInventory.AddItem(lvl4OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetOrangeGem = "";
                            PlayerMovements.BonusSp -= 135;
                            GameController.helmetSpGemBonus = 0;
                            break;


                        case "lvl5OrangeGem (gemObject)":
                            inventory.AddItem(lvl5OrangeGem, 1);
                            GemInventory.AddItem(lvl5OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetOrangeGem = "";
                            PlayerMovements.BonusSp -= 405;
                            GameController.helmetSpGemBonus = 0;
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
                            GameController.helmetHpGemBonus = 0;
                            break;

                        case "lvl2GreenGem (gemObject)":
                            inventory.AddItem(lvl2GreenGem, 1);
                            GemInventory.AddItem(lvl2GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetGreenGem = "";
                            PlayerMovements.BonusHp -= 75;
                            GameController.helmetHpGemBonus = 0;
                            break;

                        case "lvl3GreenGem (gemObject)":
                            inventory.AddItem(lvl3GreenGem, 1);
                            GemInventory.AddItem(lvl3GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetGreenGem = "";
                            PlayerMovements.BonusHp -= 225;
                            GameController.helmetHpGemBonus = 0;
                            break;

                        case "lvl4GreenGem (gemObject)":
                            inventory.AddItem(lvl4GreenGem, 1);
                            GemInventory.AddItem(lvl4GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetGreenGem = "";
                            PlayerMovements.BonusHp -= 675;
                            GameController.helmetHpGemBonus = 0;
                            break;

                        case "lvl5GreenGem (gemObject)":
                            inventory.AddItem(lvl5GreenGem, 1);
                            GemInventory.AddItem(lvl5GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.helmetGreenGem = "";
                            PlayerMovements.BonusHp -= 2025;
                            GameController.helmetHpGemBonus = 0;
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
                            GameController.gearExist = true;
                            break;
                        case "lvl 10 helmet (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 50;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 40;
                            GameController.gearExist = true;
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
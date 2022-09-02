using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BeltDropArea : MonoBehaviour, IDropHandler
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
            

            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("belt"))
            {

                if (GameController.swapGems)
                {
                    switch (GameController.beltGear)
                    {
                        case "lvl 1 belt (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 6;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 7;
                            break;
                        case "lvl 10 belt (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 30;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 50;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 35;
                            break;
                    }
                }
                else
                {
                    switch (GameController.beltRedGem)
                    {
                        case "lvl1RedGem (gemObject)":
                            inventory.AddItem(lvl1RedGem, 1);
                            GemInventory.AddItem(lvl1RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.beltRedGem = "";
                            PlayerMovements.BonusAttack -= 5;
                            break;
                    }

                    switch (GameController.beltBlueGem)
                    {
                        case "lvl1BlueGem (gemObject)":
                            inventory.AddItem(lvl1BlueGem, 1);
                            GemInventory.AddItem(lvl1BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.beltBlueGem = "";
                            PlayerMovements.BonusDefence -= 5;
                            break;
                    }


                    switch (GameController.beltYellowGem)
                    {
                        case "lvl1YellowGem (gemObject)":
                            inventory.AddItem(lvl1YellowGem, 1);
                            GemInventory.AddItem(lvl1YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.beltYellowGem = "";
                            PlayerMovements.BonusAgility -= 5;
                            break;
                    }

                    switch (GameController.beltOrangeGem)
                    {
                        case "lvl1OrangeGem (gemObject)":
                            inventory.AddItem(lvl1OrangeGem, 1);
                            GemInventory.AddItem(lvl1OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.beltOrangeGem = "";
                            PlayerMovements.BonusSp -= 5;
                            break;
                    }


                    switch (GameController.beltGreenGem)
                    {
                        case "lvl1GreenGem (gemObject)":
                            inventory.AddItem(lvl1GreenGem, 1);
                            GemInventory.AddItem(lvl1GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.beltGreenGem = "";
                            PlayerMovements.BonusHp -= 25;
                            break;
                    }
                    switch (GameController.beltGear)
                    {
                        case "lvl 1 belt (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 6;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 7;
                            break;
                        case "lvl 10 belt (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 30;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 50;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 35;
                            break;
                    }
                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                
                if (GameController.beltGear == "lvl 1 belt (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (GameController.beltGear == "lvl 10 belt (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 belt inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 belt inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        GameController.beltGear = itemObject[0].ToString();
                        break;
                    case 1:
                        GameController.beltGear = itemObject[1].ToString();

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
                BeltGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

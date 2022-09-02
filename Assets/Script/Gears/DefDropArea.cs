using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DefDropArea : MonoBehaviour, IDropHandler
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
            

            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("def"))
            {
                if (GameController.swapGems)
                {
                    switch (GameController.defGear)
                    {
                        case "lvl 1 def (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 2;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 10;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 2;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 10;
                            break;
                        case "lvl 10 def (equipmentObject)":
                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 50;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 50;

                            break;
                    }
                }
                else
                {
                    switch (GameController.shieldRedGem)
                    {
                        case "lvl1RedGem (gemObject)":
                            inventory.AddItem(lvl1RedGem, 1);
                            GemInventory.AddItem(lvl1RedGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.shieldRedGem = "";
                            PlayerMovements.BonusAttack -= 5;
                            break;
                    }

                    switch (GameController.shieldBlueGem)
                    {
                        case "lvl1BlueGem (gemObject)":
                            inventory.AddItem(lvl1BlueGem, 1);
                            GemInventory.AddItem(lvl1BlueGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.shieldBlueGem = "";
                            PlayerMovements.BonusDefence -= 5;
                            break;
                    }


                    switch (GameController.shieldYellowGem)
                    {
                        case "lvl1YellowGem (gemObject)":
                            inventory.AddItem(lvl1YellowGem, 1);
                            GemInventory.AddItem(lvl1YellowGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.shieldYellowGem = "";
                            PlayerMovements.BonusAgility -= 5;
                            break;
                    }

                    switch (GameController.shieldOrangeGem)
                    {
                        case "lvl1OrangeGem (gemObject)":
                            inventory.AddItem(lvl1OrangeGem, 1);
                            GemInventory.AddItem(lvl1OrangeGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.shieldOrangeGem = "";
                            PlayerMovements.BonusSp -= 5;
                            break;
                    }


                    switch (GameController.shieldGreenGem)
                    {
                        case "lvl1GreenGem (gemObject)":
                            inventory.AddItem(lvl1GreenGem, 1);
                            GemInventory.AddItem(lvl1GreenGem, 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                            GameController.shieldGreenGem = "";
                            PlayerMovements.BonusHp -= 25;
                            break;
                    }

                    switch (GameController.defGear)
                    {
                        case "lvl 1 def (equipmentObject)":

                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 2;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 10;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 2;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 10;
                            break;
                        case "lvl 10 def (equipmentObject)":
                            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 50;
                            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 50;

                            break;
                    }

                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                
                if (GameController.defGear == "lvl 1 def (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (GameController.defGear == "lvl 10 def (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 def inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 def inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        GameController.defGear = itemObject[0].ToString();
                        break;
                    case 1:
                        GameController.defGear = itemObject[1].ToString();

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
                DefGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

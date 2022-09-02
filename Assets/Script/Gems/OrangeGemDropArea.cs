using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class OrangeGemDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;


    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("Orange"))
            {


                if (GameController.swordOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1OrangeGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[0], 1);
                            GemInventory.AddItem(itemObject[0], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.shieldOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1OrangeGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[0], 1);
                            GemInventory.AddItem(itemObject[0], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.helmetOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1OrangeGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[0], 1);
                            GemInventory.AddItem(itemObject[0], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }
                if (GameController.beltOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1OrangeGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[0], 1);
                            GemInventory.AddItem(itemObject[0], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.ringOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1OrangeGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[0], 1);
                            GemInventory.AddItem(itemObject[0], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl1OrangeGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[0]);
                    GemInventory.RemoveItem(itemObject[0]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordOrangeGem = itemObject[0].ToString();
                        orangeGems.atkGemIsAdded = true;
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[0].ToString();
                        orangeGems.defGemIsAdded = true;
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[0].ToString();
                        orangeGems.agiGemIsAdded = true;
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[0].ToString();
                        orangeGems.spGemIsAdded = true;
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[0].ToString();
                        orangeGems.hpGemIsAdded = true;
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }
            }

        }
    }
}

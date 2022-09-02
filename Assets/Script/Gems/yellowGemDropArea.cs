using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class yellowGemDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;


    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("Yellow"))
            {

                if (GameController.swordYellowGem == "lvl1YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1YellowGem(Clone)")
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

                if (GameController.shieldYellowGem == "lvl1YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1YellowGem(Clone)")
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

                if (GameController.helmetYellowGem == "lvl1YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1YellowGem(Clone)")
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

                if (GameController.beltYellowGem == "lvl1YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1YellowGem(Clone)")
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

                if (GameController.ringYellowGem == "lvl1YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1YellowGem(Clone)")
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



                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl1YellowGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[0]);
                    GemInventory.RemoveItem(itemObject[0]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordYellowGem = itemObject[0].ToString();
                        yellowGems.atkGemIsAdded = true;
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldYellowGem = itemObject[0].ToString();
                        yellowGems.defGemIsAdded = true;
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetYellowGem = itemObject[0].ToString();
                        yellowGems.agiGemIsAdded = true;
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltYellowGem = itemObject[0].ToString();
                        yellowGems.spGemIsAdded = true;
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringYellowGem = itemObject[0].ToString();
                        yellowGems.hpGemIsAdded = true;
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class blueGemDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;


    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("Blue"))
            {

                if (GameController.swordBlueGem == "lvl1BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1BlueGem(Clone)")
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

                if (GameController.shieldBlueGem == "lvl1BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1BlueGem(Clone)")
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

                if (GameController.helmetBlueGem == "lvl1BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1BlueGem(Clone)")
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

                if (GameController.beltBlueGem == "lvl1BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1BlueGem(Clone)")
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

                if (GameController.ringBlueGem == "lvl1BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1BlueGem(Clone)")
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

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl1BlueGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[0]);
                    GemInventory.RemoveItem(itemObject[0]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordBlueGem = itemObject[0].ToString();
                        blueGems.atkGemIsAdded = true;
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldBlueGem = itemObject[0].ToString();
                        blueGems.defGemIsAdded = true;
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetBlueGem = itemObject[0].ToString();
                        blueGems.agiGemIsAdded = true;
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltBlueGem = itemObject[0].ToString();
                        blueGems.spGemIsAdded = true;
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringBlueGem = itemObject[0].ToString();
                        blueGems.hpGemIsAdded = true;
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }
            }

        }
    }
}
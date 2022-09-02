using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GreenGemDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;


    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("Green"))
            {

                if (GameController.swordGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1GreenGem(Clone)")
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

                if (GameController.shieldGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1GreenGem(Clone)")
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

                if (GameController.helmetGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1GreenGem(Clone)")
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

                if (GameController.beltGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1GreenGem(Clone)")
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

                if (GameController.ringGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1GreenGem(Clone)")
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

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl1GreenGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[0]);
                    GemInventory.RemoveItem(itemObject[0]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordGreenGem = itemObject[0].ToString();
                        greenGems.atkGemIsAdded = true;
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldGreenGem = itemObject[0].ToString();
                        greenGems.defGemIsAdded = true;
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetGreenGem = itemObject[0].ToString();
                        greenGems.agiGemIsAdded = true;
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltGreenGem = itemObject[0].ToString();
                        greenGems.spGemIsAdded = true;
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringGreenGem = itemObject[0].ToString();
                        greenGems.hpGemIsAdded = true;
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }
            }

        }
    }
}

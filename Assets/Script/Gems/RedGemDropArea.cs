using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RedGemDropArea : MonoBehaviour, IDropHandler
{

    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject[] itemObject;


    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("Red"))
            {
                if (GameController.swordRedGem == "lvl1RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1RedGem(Clone)")
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

                if (GameController.shieldRedGem == "lvl1RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1RedGem(Clone)")
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

                if (GameController.helmetRedGem == "lvl1RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1RedGem(Clone)")
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

                if (GameController.beltRedGem == "lvl1RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1RedGem(Clone)")
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

                if (GameController.ringRedGem == "lvl1RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl1RedGem(Clone)")
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


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl1RedGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[0]);
                    GemInventory.RemoveItem(itemObject[0]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {

                        GameController.swordRedGem = itemObject[0].ToString();
                        redGems.atkGemIsAdded = true;
                        redGems.isAtkGearRedGemPlaced = true;

                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {

                        GameController.shieldRedGem = itemObject[0].ToString();
                        redGems.defGemIsAdded = true;
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[0].ToString();
                        redGems.agiGemIsAdded = true;
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[0].ToString();
                        redGems.spGemIsAdded = true;
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[0].ToString();
                        redGems.hpGemIsAdded = true;
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }
            }

        }
    }
}

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

                if (GameController.swordRedGem == "lvl2RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[1], 1);
                            GemInventory.AddItem(itemObject[1], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.swordRedGem == "lvl3RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[2], 1);
                            GemInventory.AddItem(itemObject[2], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.swordRedGem == "lvl4RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[3], 1);
                            GemInventory.AddItem(itemObject[3], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.swordRedGem == "lvl5RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[4], 1);
                            GemInventory.AddItem(itemObject[4], 1);
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


                if (GameController.shieldRedGem == "lvl2RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[1], 1);
                            GemInventory.AddItem(itemObject[1], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.shieldRedGem == "lvl3RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[2], 1);
                            GemInventory.AddItem(itemObject[2], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.shieldRedGem == "lvl4RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[3], 1);
                            GemInventory.AddItem(itemObject[3], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.shieldRedGem == "lvl5RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[4], 1);
                            GemInventory.AddItem(itemObject[4], 1);
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


                if (GameController.helmetRedGem == "lvl2RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[1], 1);
                            GemInventory.AddItem(itemObject[1], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.helmetRedGem == "lvl3RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[2], 1);
                            GemInventory.AddItem(itemObject[2], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.helmetRedGem == "lvl4RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[3], 1);
                            GemInventory.AddItem(itemObject[3], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.helmetRedGem == "lvl5RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[4], 1);
                            GemInventory.AddItem(itemObject[4], 1);
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


                if (GameController.beltRedGem == "lvl2RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[1], 1);
                            GemInventory.AddItem(itemObject[1], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.beltRedGem == "lvl3RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[2], 1);
                            GemInventory.AddItem(itemObject[2], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.beltRedGem == "lvl4RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[3], 1);
                            GemInventory.AddItem(itemObject[3], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }



                if (GameController.beltRedGem == "lvl5RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[4], 1);
                            GemInventory.AddItem(itemObject[4], 1);
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


                if (GameController.ringRedGem == "lvl2RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[1], 1);
                            GemInventory.AddItem(itemObject[1], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }

                if (GameController.ringRedGem == "lvl3RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[2], 1);
                            GemInventory.AddItem(itemObject[2], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }



                if (GameController.ringRedGem == "lvl4RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[3], 1);
                            GemInventory.AddItem(itemObject[3], 1);
                            inventory.save();
                            GemInventory.save();
                            LapidaryLeftSide.refreshInv = true;
                            Inventory.refreshInv = true;
                        }
                    }

                }


                if (GameController.ringRedGem == "lvl5RedGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5RedGem(Clone)")
                        {
                            GameObject.Destroy(child.gameObject);
                            inventory.AddItem(itemObject[4], 1);
                            GemInventory.AddItem(itemObject[4], 1);
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

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl2RedGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[1]);
                    GemInventory.RemoveItem(itemObject[1]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {

                        GameController.swordRedGem = itemObject[1].ToString();
                        redGems.atkGemIsAdded = true;
                        redGems.isAtkGearRedGemPlaced = true;

                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {

                        GameController.shieldRedGem = itemObject[1].ToString();
                        redGems.defGemIsAdded = true;
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[1].ToString();
                        redGems.agiGemIsAdded = true;
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[1].ToString();
                        redGems.spGemIsAdded = true;
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[1].ToString();
                        redGems.hpGemIsAdded = true;
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl3RedGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[2]);
                    GemInventory.RemoveItem(itemObject[2]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {

                        GameController.swordRedGem = itemObject[2].ToString();
                        redGems.atkGemIsAdded = true;
                        redGems.isAtkGearRedGemPlaced = true;

                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {

                        GameController.shieldRedGem = itemObject[2].ToString();
                        redGems.defGemIsAdded = true;
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[2].ToString();
                        redGems.agiGemIsAdded = true;
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[2].ToString();
                        redGems.spGemIsAdded = true;
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[2].ToString();
                        redGems.hpGemIsAdded = true;
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl4RedGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[3]);
                    GemInventory.RemoveItem(itemObject[3]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {

                        GameController.swordRedGem = itemObject[3].ToString();
                        redGems.atkGemIsAdded = true;
                        redGems.isAtkGearRedGemPlaced = true;

                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {

                        GameController.shieldRedGem = itemObject[3].ToString();
                        redGems.defGemIsAdded = true;
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[3].ToString();
                        redGems.agiGemIsAdded = true;
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[3].ToString();
                        redGems.spGemIsAdded = true;
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[3].ToString();
                        redGems.hpGemIsAdded = true;
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl5RedGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[4]);
                    GemInventory.RemoveItem(itemObject[4]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {

                        GameController.swordRedGem = itemObject[4].ToString();
                        redGems.atkGemIsAdded = true;
                        redGems.isAtkGearRedGemPlaced = true;

                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {

                        GameController.shieldRedGem = itemObject[4].ToString();
                        redGems.defGemIsAdded = true;
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[4].ToString();
                        redGems.agiGemIsAdded = true;
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[4].ToString();
                        redGems.spGemIsAdded = true;
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[4].ToString();
                        redGems.hpGemIsAdded = true;
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }





            }

        }
    }
}

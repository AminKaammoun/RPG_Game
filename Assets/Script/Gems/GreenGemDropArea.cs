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
                    GameController.gearExist = true;
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


                if (GameController.swordGreenGem == "lvl2GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2GreenGem(Clone)")
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

                if (GameController.swordGreenGem == "lvl3GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3GreenGem(Clone)")
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


                if (GameController.swordGreenGem == "lvl4GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4GreenGem(Clone)")
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

                if (GameController.swordGreenGem == "lvl5GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5GreenGem(Clone)")
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


                if (GameController.shieldGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    GameController.gearExist = true;
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

                if (GameController.shieldGreenGem == "lvl2GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2GreenGem(Clone)")
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

                if (GameController.shieldGreenGem == "lvl3GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3GreenGem(Clone)")
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

                if (GameController.shieldGreenGem == "lvl4GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4GreenGem(Clone)")
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

                if (GameController.shieldGreenGem == "lvl5GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5GreenGem(Clone)")
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

                if (GameController.helmetGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    GameController.gearExist = true;
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

                if (GameController.helmetGreenGem == "lvl2GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2GreenGem(Clone)")
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

                if (GameController.helmetGreenGem == "lvl3GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3GreenGem(Clone)")
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

                if (GameController.helmetGreenGem == "lvl4GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4GreenGem(Clone)")
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

                if (GameController.helmetGreenGem == "lvl5GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5GreenGem(Clone)")
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

                if (GameController.beltGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    GameController.gearExist = true;
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

                if (GameController.beltGreenGem == "lvl2GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2GreenGem(Clone)")
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

                if (GameController.beltGreenGem == "lvl3GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3GreenGem(Clone)")
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

                if (GameController.beltGreenGem == "lvl4GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4GreenGem(Clone)")
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

                if (GameController.beltGreenGem == "lvl5GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5GreenGem(Clone)")
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



                if (GameController.ringGreenGem == "lvl1GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    GameController.gearExist = true;
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

                if (GameController.ringGreenGem == "lvl2GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2GreenGem(Clone)")
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

                if (GameController.ringGreenGem == "lvl3GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3GreenGem(Clone)")
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

                if (GameController.ringGreenGem == "lvl4GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4GreenGem(Clone)")
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

                if (GameController.ringGreenGem == "lvl5GreenGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5GreenGem(Clone)")
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


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl2GreenGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[1]);
                    GemInventory.RemoveItem(itemObject[1]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordGreenGem = itemObject[1].ToString();
                        greenGems.atkGemIsAdded = true;
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldGreenGem = itemObject[1].ToString();
                        greenGems.defGemIsAdded = true;
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetGreenGem = itemObject[1].ToString();
                        greenGems.agiGemIsAdded = true;
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltGreenGem = itemObject[1].ToString();
                        greenGems.spGemIsAdded = true;
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringGreenGem = itemObject[1].ToString();
                        greenGems.hpGemIsAdded = true;
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl3GreenGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[2]);
                    GemInventory.RemoveItem(itemObject[2]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordGreenGem = itemObject[2].ToString();
                        greenGems.atkGemIsAdded = true;
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldGreenGem = itemObject[2].ToString();
                        greenGems.defGemIsAdded = true;
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetGreenGem = itemObject[2].ToString();
                        greenGems.agiGemIsAdded = true;
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltGreenGem = itemObject[2].ToString();
                        greenGems.spGemIsAdded = true;
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringGreenGem = itemObject[2].ToString();
                        greenGems.hpGemIsAdded = true;
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl4GreenGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[3]);
                    GemInventory.RemoveItem(itemObject[3]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordGreenGem = itemObject[3].ToString();
                        greenGems.atkGemIsAdded = true;
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldGreenGem = itemObject[3].ToString();
                        greenGems.defGemIsAdded = true;
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetGreenGem = itemObject[3].ToString();
                        greenGems.agiGemIsAdded = true;
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltGreenGem = itemObject[3].ToString();
                        greenGems.spGemIsAdded = true;
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringGreenGem = itemObject[3].ToString();
                        greenGems.hpGemIsAdded = true;
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl5GreenGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[4]);
                    GemInventory.RemoveItem(itemObject[4]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordGreenGem = itemObject[4].ToString();
                        greenGems.atkGemIsAdded = true;
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldGreenGem = itemObject[4].ToString();
                        greenGems.defGemIsAdded = true;
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetGreenGem = itemObject[4].ToString();
                        greenGems.agiGemIsAdded = true;
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltGreenGem = itemObject[4].ToString();
                        greenGems.spGemIsAdded = true;
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringGreenGem = itemObject[4].ToString();
                        greenGems.hpGemIsAdded = true;
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }
            }

        }
    }
}

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

                if (GameController.swordBlueGem == "lvl2BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2BlueGem(Clone)")
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

                if (GameController.swordBlueGem == "lvl3BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3BlueGem(Clone)")
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


                if (GameController.swordBlueGem == "lvl4BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4BlueGem(Clone)")
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

                if (GameController.swordBlueGem == "lvl5BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5BlueGem(Clone)")
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

                if (GameController.shieldBlueGem == "lvl2BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2BlueGem(Clone)")
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

                if (GameController.shieldBlueGem == "lvl3BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3BlueGem(Clone)")
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


                if (GameController.shieldBlueGem == "lvl4BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4BlueGem(Clone)")
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

                if (GameController.shieldBlueGem == "lvl5BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5BlueGem(Clone)")
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

                if (GameController.helmetBlueGem == "lvl2BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2BlueGem(Clone)")
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

                if (GameController.helmetBlueGem == "lvl3BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3BlueGem(Clone)")
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


                if (GameController.helmetBlueGem == "lvl4BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4BlueGem(Clone)")
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

                if (GameController.helmetBlueGem == "lvl5BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5BlueGem(Clone)")
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

                if (GameController.beltBlueGem == "lvl2BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2BlueGem(Clone)")
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

                if (GameController.beltBlueGem == "lvl3BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3BlueGem(Clone)")
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

                if (GameController.beltBlueGem == "lvl4BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4BlueGem(Clone)")
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

                if (GameController.beltBlueGem == "lvl5BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5BlueGem(Clone)")
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


                if (GameController.ringBlueGem == "lvl2BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2BlueGem(Clone)")
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

                if (GameController.ringBlueGem == "lvl3BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3BlueGem(Clone)")
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


                if (GameController.ringBlueGem == "lvl4BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4BlueGem(Clone)")
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

                if (GameController.ringBlueGem == "lvl5BlueGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5BlueGem(Clone)")
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



                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl2BlueGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[1]);
                    GemInventory.RemoveItem(itemObject[1]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordBlueGem = itemObject[1].ToString();
                        blueGems.atkGemIsAdded = true;
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldBlueGem = itemObject[1].ToString();
                        blueGems.defGemIsAdded = true;
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetBlueGem = itemObject[1].ToString();
                        blueGems.agiGemIsAdded = true;
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltBlueGem = itemObject[1].ToString();
                        blueGems.spGemIsAdded = true;
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringBlueGem = itemObject[1].ToString();
                        blueGems.hpGemIsAdded = true;
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl3BlueGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[2]);
                    GemInventory.RemoveItem(itemObject[2]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordBlueGem = itemObject[2].ToString();
                        blueGems.atkGemIsAdded = true;
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldBlueGem = itemObject[2].ToString();
                        blueGems.defGemIsAdded = true;
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetBlueGem = itemObject[2].ToString();
                        blueGems.agiGemIsAdded = true;
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltBlueGem = itemObject[2].ToString();
                        blueGems.spGemIsAdded = true;
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringBlueGem = itemObject[2].ToString();
                        blueGems.hpGemIsAdded = true;
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl4BlueGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[3]);
                    GemInventory.RemoveItem(itemObject[3]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordBlueGem = itemObject[3].ToString();
                        blueGems.atkGemIsAdded = true;
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldBlueGem = itemObject[3].ToString();
                        blueGems.defGemIsAdded = true;
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetBlueGem = itemObject[3].ToString();
                        blueGems.agiGemIsAdded = true;
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltBlueGem = itemObject[3].ToString();
                        blueGems.spGemIsAdded = true;
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringBlueGem = itemObject[3].ToString();
                        blueGems.hpGemIsAdded = true;
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl5BlueGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[4]);
                    GemInventory.RemoveItem(itemObject[4]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordBlueGem = itemObject[4].ToString();
                        blueGems.atkGemIsAdded = true;
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldBlueGem = itemObject[4].ToString();
                        blueGems.defGemIsAdded = true;
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetBlueGem = itemObject[4].ToString();
                        blueGems.agiGemIsAdded = true;
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltBlueGem = itemObject[4].ToString();
                        blueGems.spGemIsAdded = true;
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringBlueGem = itemObject[4].ToString();
                        blueGems.hpGemIsAdded = true;
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }
            }

        }
    }
}

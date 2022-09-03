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

                if (GameController.swordYellowGem == "lvl2YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2YellowGem(Clone)")
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


                if (GameController.swordYellowGem == "lvl3YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3YellowGem(Clone)")
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


                if (GameController.swordYellowGem == "lvl4YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4YellowGem(Clone)")
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

                if (GameController.swordYellowGem == "lvl5YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5YellowGem(Clone)")
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

                if (GameController.shieldYellowGem == "lvl2YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2YellowGem(Clone)")
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


                if (GameController.shieldYellowGem == "lvl3YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3YellowGem(Clone)")
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


                if (GameController.shieldYellowGem == "lvl4YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4YellowGem(Clone)")
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

                if (GameController.shieldYellowGem == "lvl5YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5YellowGem(Clone)")
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


                if (GameController.helmetYellowGem == "lvl2YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2YellowGem(Clone)")
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


                if (GameController.helmetYellowGem == "lvl3YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3YellowGem(Clone)")
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


                if (GameController.helmetYellowGem == "lvl4YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4YellowGem(Clone)")
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

                if (GameController.helmetYellowGem == "lvl5YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5YellowGem(Clone)")
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

                if (GameController.beltYellowGem == "lvl2YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2YellowGem(Clone)")
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


                if (GameController.beltYellowGem == "lvl3YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3YellowGem(Clone)")
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


                if (GameController.beltYellowGem == "lvl4YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4YellowGem(Clone)")
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

                if (GameController.beltYellowGem == "lvl5YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5YellowGem(Clone)")
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

                if (GameController.ringYellowGem == "lvl2YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2YellowGem(Clone)")
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


                if (GameController.ringYellowGem == "lvl3YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3YellowGem(Clone)")
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


                if (GameController.ringYellowGem == "lvl4YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4YellowGem(Clone)")
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

                if (GameController.ringYellowGem == "lvl5YellowGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;

                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5YellowGem(Clone)")
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

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl2YellowGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[1]);
                    GemInventory.RemoveItem(itemObject[1]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordYellowGem = itemObject[1].ToString();
                        yellowGems.atkGemIsAdded = true;
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldYellowGem = itemObject[1].ToString();
                        yellowGems.defGemIsAdded = true;
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetYellowGem = itemObject[1].ToString();
                        yellowGems.agiGemIsAdded = true;
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltYellowGem = itemObject[1].ToString();
                        yellowGems.spGemIsAdded = true;
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringYellowGem = itemObject[1].ToString();
                        yellowGems.hpGemIsAdded = true;
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl3YellowGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[2]);
                    GemInventory.RemoveItem(itemObject[2]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordYellowGem = itemObject[2].ToString();
                        yellowGems.atkGemIsAdded = true;
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldYellowGem = itemObject[2].ToString();
                        yellowGems.defGemIsAdded = true;
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetYellowGem = itemObject[2].ToString();
                        yellowGems.agiGemIsAdded = true;
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltYellowGem = itemObject[2].ToString();
                        yellowGems.spGemIsAdded = true;
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringYellowGem = itemObject[2].ToString();
                        yellowGems.hpGemIsAdded = true;
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl4YellowGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[3]);
                    GemInventory.RemoveItem(itemObject[3]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordYellowGem = itemObject[3].ToString();
                        yellowGems.atkGemIsAdded = true;
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldYellowGem = itemObject[3].ToString();
                        yellowGems.defGemIsAdded = true;
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetYellowGem = itemObject[3].ToString();
                        yellowGems.agiGemIsAdded = true;
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltYellowGem = itemObject[3].ToString();
                        yellowGems.spGemIsAdded = true;
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringYellowGem = itemObject[3].ToString();
                        yellowGems.hpGemIsAdded = true;
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl5YellowGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[4]);
                    GemInventory.RemoveItem(itemObject[4]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordYellowGem = itemObject[4].ToString();
                        yellowGems.atkGemIsAdded = true;
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldYellowGem = itemObject[4].ToString();
                        yellowGems.defGemIsAdded = true;
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetYellowGem = itemObject[4].ToString();
                        yellowGems.agiGemIsAdded = true;
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltYellowGem = itemObject[4].ToString();
                        yellowGems.spGemIsAdded = true;
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringYellowGem = itemObject[4].ToString();
                        yellowGems.hpGemIsAdded = true;
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }
            }

        }
    }
}

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
                    GameController.gearExist = true;
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

                if (GameController.swordOrangeGem == "lvl2OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2OrangeGem(Clone)")
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

                if (GameController.swordOrangeGem == "lvl3OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3OrangeGem(Clone)")
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

                if (GameController.swordOrangeGem == "lvl4OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4OrangeGem(Clone)")
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

                if (GameController.swordOrangeGem == "lvl5OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.sword)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5OrangeGem(Clone)")
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

                if (GameController.shieldOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
                    GameController.gearExist = true;
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


                if (GameController.shieldOrangeGem == "lvl2OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2OrangeGem(Clone)")
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

                if (GameController.shieldOrangeGem == "lvl3OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3OrangeGem(Clone)")
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

                if (GameController.shieldOrangeGem == "lvl4OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4OrangeGem(Clone)")
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

                if (GameController.shieldOrangeGem == "lvl5OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.shield)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5OrangeGem(Clone)")
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


                if (GameController.helmetOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
                    GameController.gearExist = true;
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

                if (GameController.helmetOrangeGem == "lvl2OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2OrangeGem(Clone)")
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


                if (GameController.helmetOrangeGem == "lvl3OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3OrangeGem(Clone)")
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

                if (GameController.helmetOrangeGem == "lvl4OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4OrangeGem(Clone)")
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

                if (GameController.helmetOrangeGem == "lvl5OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.helmet)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5OrangeGem(Clone)")
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


                if (GameController.beltOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
                    GameController.gearExist = true;
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

                if (GameController.beltOrangeGem == "lvl2OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2OrangeGem(Clone)")
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

                if (GameController.beltOrangeGem == "lvl3OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3OrangeGem(Clone)")
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

                if (GameController.beltOrangeGem == "lvl4OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4OrangeGem(Clone)")
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

                if (GameController.beltOrangeGem == "lvl5OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.belt)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5OrangeGem(Clone)")
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

                if (GameController.ringOrangeGem == "lvl1OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
                    GameController.gearExist = true;
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

                if (GameController.ringOrangeGem == "lvl2OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl2OrangeGem(Clone)")
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

                if (GameController.ringOrangeGem == "lvl3OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl3OrangeGem(Clone)")
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

                if (GameController.ringOrangeGem == "lvl4OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl4OrangeGem(Clone)")
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

                if (GameController.ringOrangeGem == "lvl5OrangeGem (gemObject)" && LapidaryLeftSide.currentgear == SelectedGear.ring)
                {
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
                    GameController.gearExist = true;
                    foreach (Transform child in transform)
                    {
                        if (child.gameObject.name == "lvl5OrangeGem(Clone)")
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


                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl2OrangeGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[1]);
                    GemInventory.RemoveItem(itemObject[1]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordOrangeGem = itemObject[1].ToString();
                        orangeGems.atkGemIsAdded = true;
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[1].ToString();
                        orangeGems.defGemIsAdded = true;
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[1].ToString();
                        orangeGems.agiGemIsAdded = true;
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[1].ToString();
                        orangeGems.spGemIsAdded = true;
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[1].ToString();
                        orangeGems.hpGemIsAdded = true;
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl3OrangeGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[2]);
                    GemInventory.RemoveItem(itemObject[2]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordOrangeGem = itemObject[2].ToString();
                        orangeGems.atkGemIsAdded = true;
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[2].ToString();
                        orangeGems.defGemIsAdded = true;
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[2].ToString();
                        orangeGems.agiGemIsAdded = true;
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[2].ToString();
                        orangeGems.spGemIsAdded = true;
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[2].ToString();
                        orangeGems.hpGemIsAdded = true;
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl4OrangeGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[3]);
                    GemInventory.RemoveItem(itemObject[3]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordOrangeGem = itemObject[3].ToString();
                        orangeGems.atkGemIsAdded = true;
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[3].ToString();
                        orangeGems.defGemIsAdded = true;
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[3].ToString();
                        orangeGems.agiGemIsAdded = true;
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[3].ToString();
                        orangeGems.spGemIsAdded = true;
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[3].ToString();
                        orangeGems.hpGemIsAdded = true;
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl5OrangeGem(Clone)")
                {
                    inventory.RemoveItem(itemObject[4]);
                    GemInventory.RemoveItem(itemObject[4]);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;

                    if (LapidaryLeftSide.currentgear == SelectedGear.sword)
                    {
                        GameController.swordOrangeGem = itemObject[4].ToString();
                        orangeGems.atkGemIsAdded = true;
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[4].ToString();
                        orangeGems.defGemIsAdded = true;
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[4].ToString();
                        orangeGems.agiGemIsAdded = true;
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[4].ToString();
                        orangeGems.spGemIsAdded = true;
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[4].ToString();
                        orangeGems.hpGemIsAdded = true;
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }
            }

        }
    }
}

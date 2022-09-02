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
                        orangeGems.isAtkGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        GameController.shieldOrangeGem = itemObject[0].ToString();
                        orangeGems.isDefGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetOrangeGem = itemObject[0].ToString();
                        orangeGems.isHelmetGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltOrangeGem = itemObject[0].ToString();
                        orangeGems.isBeltGearOrangeGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringOrangeGem = itemObject[0].ToString();
                        orangeGems.isRingGearOrangeGemPlaced = true;
                    }

                }
            }

        }
    }
}

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
                        redGems.isAtkGearRedGemPlaced = true;
                        
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                      
                        GameController.shieldRedGem = itemObject[0].ToString();
                        redGems.isDefGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        GameController.helmetRedGem = itemObject[0].ToString();
                        redGems.isHelmetGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        GameController.beltRedGem = itemObject[0].ToString();
                        redGems.isBeltGearRedGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        GameController.ringRedGem = itemObject[0].ToString();
                        redGems.isRingGearRedGemPlaced = true;
                    }

                }
            }
            
        }
    }
}

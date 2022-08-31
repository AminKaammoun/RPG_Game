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
                        PlayerPrefs.SetString("AttackGearGreenGem", itemObject[0].ToString());
                        greenGems.isAtkGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        PlayerPrefs.SetString("DefGearGreenGem", itemObject[0].ToString());
                        greenGems.isDefGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        PlayerPrefs.SetString("HelmetGearGreenGem", itemObject[0].ToString());
                        greenGems.isHelmetGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        PlayerPrefs.SetString("BeltGearGreenGem", itemObject[0].ToString());
                        greenGems.isBeltGearGreenGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        PlayerPrefs.SetString("RingGearGreenGem", itemObject[0].ToString());
                        greenGems.isRingGearGreenGemPlaced = true;
                    }

                }
            }

        }
    }
}

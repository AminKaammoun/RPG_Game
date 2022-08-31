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
                        PlayerPrefs.SetString("AttackGearYellowGem", itemObject[0].ToString());
                        yellowGems.isAtkGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        PlayerPrefs.SetString("DefGearYellowGem", itemObject[0].ToString());
                        yellowGems.isDefGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        PlayerPrefs.SetString("HelmetGearYellowGem", itemObject[0].ToString());
                        yellowGems.isHelmetGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        PlayerPrefs.SetString("BeltGearYellowGem", itemObject[0].ToString());
                        yellowGems.isBeltGearYellowGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        PlayerPrefs.SetString("RingGearYellowGem", itemObject[0].ToString());
                        yellowGems.isRingGearYellowGemPlaced = true;
                    }

                }
            }

        }
    }
}

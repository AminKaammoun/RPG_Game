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
                        PlayerPrefs.SetString("AttackGearBlueGem", itemObject[0].ToString());
                        blueGems.isAtkGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
                    {
                        PlayerPrefs.SetString("DefGearBlueGem", itemObject[0].ToString());
                        blueGems.isDefGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
                    {
                        PlayerPrefs.SetString("HelmetGearBlueGem", itemObject[0].ToString());
                        blueGems.isHelmetGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
                    {
                        PlayerPrefs.SetString("BeltGearBlueGem", itemObject[0].ToString());
                        blueGems.isBeltGearBlueGemPlaced = true;
                    }
                    else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
                    {
                        PlayerPrefs.SetString("RingGearBlueGem", itemObject[0].ToString());
                        blueGems.isRingGearBlueGemPlaced = true;
                    }

                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class smallSpeedPotion : MonoBehaviour
{
    public GameObject panel;
    public ItemObject SmallSpeedPotion;
    public InventoryObject inventory;
    public TextMeshProUGUI text;
    public GameObject item;
    public GameObject[] panels;
    public string description;

    public void showPanel()
    {
        panels = GameObject.FindGameObjectsWithTag("panel");
        foreach (GameObject r in panels)
        {
            r.SetActive(false);
        }
        panel.SetActive(true);
        Inventory.description = "Magic potion used to gain extra movement speed for 10 seconds.";
    }
    public void useButton()
    {
        if (!PlayerMovements.PotionInUse)
        {
            ArrowSpawn.canShoot = true;
            PlayerMovements.changeCursor = true;
            PlayerMovements.invIsOpen = false;
            PlayerMovements.isSmallSpeeded = true;
            PlayerMovements.PotionInUse = true;

            panel.SetActive(false);
            //PlayerMovements.health += 50;
            inventory.RemoveItem(SmallSpeedPotion);
            inventory.save();

            if (text.text == "X1")
            {

                Destroy(item);
            }
            inventory.save();
        }
    }
    
}

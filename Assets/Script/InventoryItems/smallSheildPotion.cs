using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class smallSheildPotion : MonoBehaviour
{
    public GameObject panel;
    public ItemObject SmallSheildPotion;
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
        Inventory.description = "Magic potion used to not receive damage for 5 seconds.";
    }
    public void useButton()
    {
        if (!PlayerMovements.PotionInUse)
        {
            PlayerMovements.invIsOpen = false;
            PlayerMovements.isSmallSheilded = true;
            PlayerMovements.PotionInUse = true;

            panel.SetActive(false);
            //PlayerMovements.health += 50;
            inventory.RemoveItem(SmallSheildPotion);
            inventory.save();

            if (text.text == "X1")
            {

                Destroy(item);
            }
            inventory.save();

        }

    }
}

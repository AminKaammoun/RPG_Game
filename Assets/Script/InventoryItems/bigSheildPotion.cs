using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bigSheildPotion : MonoBehaviour
{
    public GameObject panel;
    public ItemObject BigSheildPotion;
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
        Inventory.description = "Magic potion used to not receive damage for 10 seconds.";
    }
    public void useButton()
    {

        PlayerMovements.invIsOpen = false;
        PlayerMovements.isBigSheilded = true;


        panel.SetActive(false);
        //PlayerMovements.health += 50;
        inventory.RemoveItem(BigSheildPotion);
        inventory.save();

        if (text.text == "X1")
        {

            Destroy(item);
        }
        inventory.save();



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class bigHealthPotion : MonoBehaviour
{

    public GameObject panel;
    public ItemObject BigHealthPotion;
    public InventoryObject inventory;
    public TextMeshProUGUI text;
    public GameObject item;
    public GameObject[] panels;
    public string description;
    public GameObject toolTip;

    public void showPanel()
    {
        panels = GameObject.FindGameObjectsWithTag("panel");
        foreach (GameObject r in panels)
        {
            r.SetActive(false);
        }
        panel.SetActive(true);
        Inventory.description = "Magic potion used to restore 50 health.";
    }
    public void useButton()
    {
        if (!PlayerMovements.healthIsMax)
        {
            PlayerMovements.invIsOpen = false;
            PlayerMovements.isHealed = true;


            panel.SetActive(false);
            PlayerMovements.health += 50;
            inventory.RemoveItem(BigHealthPotion);
            inventory.save();

            if (text.text == "X1")
            {

                Destroy(item);
            }
            inventory.save();
        }
        else
        {
            panel.SetActive(false);
            GameController.showAlert = true;
        }

    }



}

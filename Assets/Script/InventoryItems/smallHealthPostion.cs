using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class smallHealthPostion : MonoBehaviour
{

    public GameObject panel;
    public ItemObject smallHealthPotion;
    public InventoryObject inventory;
    public TextMeshProUGUI text;
    public GameObject item;
    public GameObject[] panels;
    public string description ;

    public void showPanel()
    {
        panels = GameObject.FindGameObjectsWithTag("panel");
        foreach (GameObject r in panels)
        {
            r.SetActive(false);
        }

        panel.SetActive(true);
        Inventory.description = "Magic potion used to restore 20 health.";
    }
    public void useButton()
    {
        if (!PlayerMovements.healthIsMax)
        {
            ArrowSpawn.canShoot = true;
            PlayerMovements.changeCursor = true;
            PlayerMovements.invIsOpen = false;
            PlayerMovements.isHealed = true;

           
            panel.SetActive(false);
            PlayerMovements.health += 20;
            inventory.RemoveItem(smallHealthPotion);
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

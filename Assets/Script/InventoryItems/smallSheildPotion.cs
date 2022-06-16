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
        Inventory.description = "small sheild potion";
    }
    public void useButton()
    {
       
            PlayerMovements.invIsOpen = false;
            //PlayerMovements.isHealed = true;


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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallHealthPostion : MonoBehaviour
{

    public GameObject panel;
    public ItemObject smallHealthPotion;
    public InventoryObject inventory;

    public void showPanel()
    {
        panel.SetActive(true);
        
    }
    public void useButton()
    {
        PlayerMovements.invIsOpen = false;
        PlayerMovements.isHealed = true;

        panel.SetActive(false);
        PlayerMovements.health += 20;
        inventory.RemoveItem(smallHealthPotion);
        inventory.save();

    }
    
   
}

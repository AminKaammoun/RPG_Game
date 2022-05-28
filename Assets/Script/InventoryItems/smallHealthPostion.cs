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
        
        if (text.text == "X1")
        {
            
            Destroy(item);
        }
        inventory.save();


    }
    
   
}

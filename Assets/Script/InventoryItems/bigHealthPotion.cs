using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bigHealthPotion : MonoBehaviour
{
    public GameObject panel;
    public ItemObject BigHealthPotion;
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
        PlayerMovements.health += 50;
        inventory.RemoveItem(BigHealthPotion);
        inventory.save();
        
        if (text.text == "X1")
        {

            Destroy(item);
        }
        inventory.save();


    }


}

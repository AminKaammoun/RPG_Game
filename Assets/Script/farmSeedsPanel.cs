using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmSeedsPanel : MonoBehaviour
{
  
    public GameObject[] buttons;
    public InventoryObject inventory;
    public ItemObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkExist(inventory, objects[0]))
        {
            buttons[0].SetActive(true);
        }
        else
        {
            buttons[0].SetActive(false);
        }
        if (checkExist(inventory, objects[1]))
        {
            buttons[1].SetActive(true);
        }
        else
        {
            buttons[1].SetActive(false);
        }
        if (checkExist(inventory, objects[2]))
        {
            buttons[2].SetActive(true);
        }
        else
        {
            buttons[2].SetActive(false);
        }
        if (checkExist(inventory, objects[3]))
        {
            buttons[3].SetActive(true);
        }
        else
        {
            buttons[3].SetActive(false);
        }
        if (checkExist(inventory, objects[4]))
        {
            buttons[4].SetActive(true);
        }
        else
        {
            buttons[4].SetActive(false);
        }
        if (checkExist(inventory, objects[5]))
        {
            buttons[5].SetActive(true);
        }
        else
        {
            buttons[5].SetActive(false);
        }
        if (checkExist(inventory, objects[6]))
        {
            buttons[6].SetActive(true);
        }
        else
        {
            buttons[6].SetActive(false);
        }
        if (checkExist(inventory, objects[7]))
        {
            buttons[7].SetActive(true);
        }
        else
        {
            buttons[7].SetActive(false);
        }
        if (checkExist(inventory, objects[8]))
        {
            buttons[8].SetActive(true);
        }
        else
        {
            buttons[8].SetActive(false);
        }
        if (checkExist(inventory, objects[9]))
        {
            buttons[9].SetActive(true);
        }
        else
        {
            buttons[9].SetActive(false);
        }
        if (checkExist(inventory, objects[10]))
        {
            buttons[10].SetActive(true);
        }
        else
        {
            buttons[10].SetActive(false);
        }
        if (checkExist(inventory, objects[11]))
        {
            buttons[11].SetActive(true);
        }
        else
        {
            buttons[11].SetActive(false);
        }
        if (checkExist(inventory, objects[12]))
        {
            buttons[12].SetActive(true);
        }
        else
        {
            buttons[12].SetActive(false);
        }
        if (checkExist(inventory, objects[13]))
        {
            buttons[13].SetActive(true);
        }
        else
        {
            buttons[13].SetActive(false);
        }
        if (checkExist(inventory, objects[14]))
        {
            buttons[14].SetActive(true);
        }
        else
        {
            buttons[14].SetActive(false);
        }
        if (checkExist(inventory, objects[15]))
        {
            buttons[15].SetActive(true);
        }
        else
        {
            buttons[15].SetActive(false);
        }
        if (checkExist(inventory, objects[16]))
        {
            buttons[16].SetActive(true);
        }
        else
        {
            buttons[16].SetActive(false);
        }
        if (checkExist(inventory, objects[17]))
        {
            buttons[17].SetActive(true);
        }
        else
        {
            buttons[17].SetActive(false);
        }
        if (checkExist(inventory, objects[18]))
        {
            buttons[18].SetActive(true);
        }
        else
        {
            buttons[18].SetActive(false);
        }
        if (checkExist(inventory, objects[19]))
        {
            buttons[19].SetActive(true);
        }
        else
        {
            buttons[19].SetActive(false);
        }
        if (checkExist(inventory, objects[20]))
        {
            buttons[20].SetActive(true);
        }
        else
        {
            buttons[20].SetActive(false);
        }
      

    }
    bool checkExist(InventoryObject inventory, ItemObject item)
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == item)
            {
                return true;
            }

        }
        return false;
    }

}

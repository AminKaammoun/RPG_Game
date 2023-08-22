using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class farmSeedsPanel : MonoBehaviour
{
  
    public GameObject[] buttons;
    public InventoryObject inventory;
    public ItemObject[] objects;
    public TextMeshProUGUI[] amount;
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
            amount[0].text = "x"+getAmount(objects[0]).ToString();
        }
        else
        {
            buttons[0].SetActive(false);
            amount[0].text = "x0";

        }
        if (checkExist(inventory, objects[1]))
        {
            buttons[1].SetActive(true);
            amount[1].text = "x" + getAmount(objects[1]).ToString();
        }
        else
        {
            buttons[1].SetActive(false);
            amount[1].text = "x0";
        }
        if (checkExist(inventory, objects[2]))
        {
            buttons[2].SetActive(true);
            amount[2].text = "x" + getAmount(objects[2]).ToString();
        }
        else
        {
            buttons[2].SetActive(false);
            amount[2].text = "x0";
        }
        if (checkExist(inventory, objects[3]))
        {
            buttons[3].SetActive(true);
            amount[3].text = "x" + getAmount(objects[3]).ToString();
        }
        else
        {
            buttons[3].SetActive(false);
            amount[3].text = "x0";
        }
        if (checkExist(inventory, objects[4]))
        {
            buttons[4].SetActive(true);
            amount[4].text = "x" + getAmount(objects[4]).ToString();
        }
        else
        {
            buttons[4].SetActive(false);
            amount[4].text = "x0";
        }
        if (checkExist(inventory, objects[5]))
        {
            buttons[5].SetActive(true);
            amount[5].text = "x" + getAmount(objects[5]).ToString();
        }
        else
        {
            buttons[5].SetActive(false);
            amount[5].text = "x0";
        }
        if (checkExist(inventory, objects[6]))
        {
            buttons[6].SetActive(true);
            amount[6].text = "x" + getAmount(objects[6]).ToString();
        }
        else
        {
            buttons[6].SetActive(false);
            amount[6].text = "x0";
        }
        if (checkExist(inventory, objects[7]))
        {
            buttons[7].SetActive(true);
            amount[7].text = "x" + getAmount(objects[7]).ToString();
        }
        else
        {
            buttons[7].SetActive(false);
            amount[7].text = "x0";
        }
        if (checkExist(inventory, objects[8]))
        {
            buttons[8].SetActive(true);
            amount[8].text = "x" + getAmount(objects[8]).ToString();
        }
        else
        {
            buttons[8].SetActive(false);
            amount[8].text = "x0";
        }
        if (checkExist(inventory, objects[9]))
        {
            buttons[9].SetActive(true);
            amount[9].text = "x" + getAmount(objects[9]).ToString();
        }
        else
        {
            buttons[9].SetActive(false);
            amount[9].text = "x0";
        }
        if (checkExist(inventory, objects[10]))
        {
            buttons[10].SetActive(true);
            amount[10].text = "x" + getAmount(objects[10]).ToString();
        }
        else
        {
            buttons[10].SetActive(false);
            amount[10].text = "x0";
        }
        if (checkExist(inventory, objects[11]))
        {
            buttons[11].SetActive(true);
            amount[11].text = "x" + getAmount(objects[11]).ToString();
        }
        else
        {
            buttons[11].SetActive(false);
            amount[11].text = "x0";
        }
        if (checkExist(inventory, objects[12]))
        {
            buttons[12].SetActive(true);
            amount[12].text = "x" + getAmount(objects[12]).ToString();
        }
        else
        {
            buttons[12].SetActive(false);
            amount[12].text = "x0";
        }
        if (checkExist(inventory, objects[13]))
        {
            buttons[13].SetActive(true);
            amount[13].text = "x" + getAmount(objects[13]).ToString();
        }
        else
        {
            buttons[13].SetActive(false);
            amount[13].text = "x0";
        }
        if (checkExist(inventory, objects[14]))
        {
            buttons[14].SetActive(true);
            amount[14].text = "x" + getAmount(objects[14]).ToString();
        }
        else
        {
            buttons[14].SetActive(false); 
            amount[14].text = "x0";
        }
        if (checkExist(inventory, objects[15]))
        {
            buttons[15].SetActive(true);
            amount[15].text = "x" + getAmount(objects[15]).ToString();
        }
        else
        {
            buttons[15].SetActive(false);
            amount[15].text = "x0";
        }
        if (checkExist(inventory, objects[16]))
        {
            buttons[16].SetActive(true);
            amount[16].text = "x" + getAmount(objects[16]).ToString();
        }
        else
        {
            buttons[16].SetActive(false);
            amount[16].text = "x0";
        }
        if (checkExist(inventory, objects[17]))
        {
            buttons[17].SetActive(true);
            amount[17].text = "x" + getAmount(objects[17]).ToString();
        }
        else
        {
            buttons[17].SetActive(false);
            amount[17].text = "x0";
        }
        if (checkExist(inventory, objects[18]))
        {
            buttons[18].SetActive(true);
            amount[18].text = "x" + getAmount(objects[18]).ToString();
        }
        else
        {
            buttons[18].SetActive(false);
            amount[18].text = "x0";
        }
        if (checkExist(inventory, objects[19]))
        {
            buttons[19].SetActive(true);
            amount[19].text = "x" + getAmount(objects[19]).ToString();
        }
        else
        {
            buttons[19].SetActive(false);
            amount[19].text = "x0";
        }
        if (checkExist(inventory, objects[20]))
        {
            buttons[20].SetActive(true);
            amount[20].text = "x" + getAmount(objects[20]).ToString();
        }
        else
        {
            buttons[20].SetActive(false);
            amount[20].text = "x0";
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

    int getAmount(ItemObject item)
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == item)
            {
                return inventory.Container[i].amount;
            }

        }
        return 0;
    }

}

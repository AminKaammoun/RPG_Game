using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public InventoryObject inventory;

    
    public int Xstart;
    public int Ystart;
    public int XspaceBtwItem;
    public int NumberOfColumns;
    public int YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static string description;
    public TextMeshProUGUI text;
    

    public static bool refreshInv = false;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = description;
        UpdateDisplay();
        if (refreshInv)
        {
            CreateDisplay();
            refreshInv = false;
        }
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {

            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
            }

            else
            {
                var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                itemsDisplayed.Add(inventory.Container[i], obj);

            }

        }
    }


    public void CreateDisplay()
    {
       
        for (int i = 0; i < inventory.Container.Count; i++)
        {
           
                var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                itemsDisplayed.Add(inventory.Container[i], obj);
            
        }
    }
    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }

    
}

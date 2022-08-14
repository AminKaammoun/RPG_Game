using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public enum showInv
{
    full,
    gears,
    potions,
    materials
}

public class Inventory : MonoBehaviour
{
    public InventoryObject inventory;
    private InventoryObject inv;

    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static string description;
   


    public static bool refreshInv = false;

    private showInv currentInv;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
        currentInv = showInv.full;
    }

    // Update is called once per frame
    void Update()
    {

 
        if (refreshInv)
        {
            itemsDisplayed.Clear();
            GameObject[] potions = GameObject.FindGameObjectsWithTag("potionIcon");
            GameObject[] equipments = GameObject.FindGameObjectsWithTag("equipIcon");
            GameObject[] materials = GameObject.FindGameObjectsWithTag("materialIcon");

            foreach (GameObject potion in potions)
            {
                Destroy(potion);
            }
            foreach (GameObject equipment in equipments)
            {
                Destroy(equipment);
            }
            foreach (GameObject material in materials)
            {
                Destroy(material);
            }

            CreateDisplay();
            refreshInv = false;

        }
        UpdateDisplay();

    }
    public void UpdateDisplay()
    {
        if (currentInv == showInv.full)
        {
            for (int i = 0; i < inventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(inventory.Container[i]))
                {
                    if ((inventory.Container[i].item.type == ItemType.Potion || inventory.Container[i].item.type == ItemType.Materiel) && inventory.Container[i] != null)
                    {
                        itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    if (inventory.Container[i].item.type == ItemType.Potion || inventory.Container[i].item.type == ItemType.Materiel)
                    {
                        obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                    itemsDisplayed.Add(inventory.Container[i], obj);

                }

            }
        }

        else if (currentInv == showInv.gears)
        {
            
            for (int i = 0; i < inventory.Container.Count; i++)
            {

                if (inventory.Container[i].item.type == ItemType.Equipment && !itemsDisplayed.ContainsKey(inventory.Container[i]))
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(inventory.Container[i], obj);
                   
                }

            }

        }
        else if (currentInv == showInv.potions)
        {

            for (int i = 0; i < inventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(inventory.Container[i]))
                {
                    if ((inventory.Container[i].item.type == ItemType.Potion) && inventory.Container[i] != null)
                    {
                        itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (inventory.Container[i].item.type == ItemType.Potion)
                    {
                        var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (inventory.Container[i].item.type == ItemType.Potion)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(inventory.Container[i], obj);

                    }
                }
            }

        }
        else if (currentInv == showInv.materials)
        {

            for (int i = 0; i < inventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(inventory.Container[i]))
                {
                    if ((inventory.Container[i].item.type == ItemType.Materiel) && inventory.Container[i] != null)
                    {
                        itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (inventory.Container[i].item.type == ItemType.Materiel)
                    {
                        var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (inventory.Container[i].item.type == ItemType.Materiel)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(inventory.Container[i], obj);

                    }
                }

            }

        }

    }

    public void CreateDisplay()
    {
        if (currentInv == showInv.full)
        {
            
            for (int i = 0; i < inventory.Container.Count; i++)
            {

                var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                if (inventory.Container[i].item.type == ItemType.Potion)
                {
                    obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                }
                itemsDisplayed.Add(inventory.Container[i], obj);

            }
        }
        else if (currentInv == showInv.gears)
        {
           
            for (int i = 0; i < inventory.Container.Count; i++)
            {
                if (inventory.Container[i].item.type == ItemType.Equipment)
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(inventory.Container[i], obj);
                   
                }
            }
        }
        else if (currentInv == showInv.potions)
        {

            for (int i = 0; i < inventory.Container.Count; i++)
            {
                if (inventory.Container[i].item.type == ItemType.Potion)
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(inventory.Container[i], obj);

                }
            }
        }
        else if (currentInv == showInv.materials)
        {

            for (int i = 0; i < inventory.Container.Count; i++)
            {
                if (inventory.Container[i].item.type == ItemType.Materiel)
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(inventory.Container[i], obj);

                }
            }
        }
    }


    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }

    public void ShowGears()
    {
        currentInv = showInv.gears;
        refreshInv = true;
    }
    public void ShowAll()
    {
        currentInv = showInv.full;
        refreshInv = true;
    }
    public void ShowPotions()
    {
        currentInv = showInv.potions;
        refreshInv = true;
    }
    public void ShowMaterials()
    {
        currentInv = showInv.materials;
        refreshInv = true;
    }
}

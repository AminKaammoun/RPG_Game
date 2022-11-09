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
    materials,
    gems,
    meats
}

public class Inventory : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject meatInventory;
    public InventoryObject gemsInventory;
    public InventoryObject gearsInventory;
    public InventoryObject materialsInventory;
    public InventoryObject potionsInventory;

    private InventoryObject inv;

    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static string description;
    public GameObject ability1;
    public GameObject ability2;
    public GameObject ability3;

    public static bool refreshInv = false;

    private showInv currentInv;

    public GameObject BigHealth;
    public GameObject SmallHealth;
    public GameObject BigShield;
    public GameObject SmallShield;
    public GameObject BigSpeed;
    public GameObject SmallSpeed;

    public GameObject fullInventory;
    public GameObject gearInventory;
    public GameObject gemInventory;
    public GameObject materialInventory;
    public GameObject potionInventory;
    public GameObject meatsInventory;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
        currentInv = showInv.full;
        fullInventory.SetActive(true);
        gearInventory.SetActive(false);
        materialInventory.SetActive(false);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        if (refreshInv)
        {
            Ability1Potion.isPlaced = true;
            Ability2Potion.isPlaced = true;
            Ability3Potion.isPlaced = true;

            itemsDisplayed.Clear();
            GameObject[] potions = GameObject.FindGameObjectsWithTag("potionIcon");
            GameObject[] equipments = GameObject.FindGameObjectsWithTag("equipIcon");
            GameObject[] materials = GameObject.FindGameObjectsWithTag("materialIcon");
            GameObject[] gems = GameObject.FindGameObjectsWithTag("gemIcon");
            GameObject[] fishes = GameObject.FindGameObjectsWithTag("fishIcons");
            GameObject[] foods = GameObject.FindGameObjectsWithTag("foodIcon");

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
            foreach (GameObject gem in gems)
            {
                Destroy(gem);
            }
            foreach (GameObject fish in fishes)
            {
                Destroy(fish);
            }
            foreach (GameObject food in foods)
            {
                Destroy(food);
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
                    if ((inventory.Container[i].item.type == ItemType.Potion || inventory.Container[i].item.type == ItemType.Materiel || inventory.Container[i].item.type == ItemType.Gem || inventory.Container[i].item.type == ItemType.fish || inventory.Container[i].item.type == ItemType.Food || inventory.Container[i].item.type == ItemType.egg) && inventory.Container[i] != null)
                    {
                        itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    if (inventory.Container[i].item.type == ItemType.Potion || inventory.Container[i].item.type == ItemType.Materiel || inventory.Container[i].item.type == ItemType.Gem || inventory.Container[i].item.type == ItemType.fish || meatInventory.Container[i].item.type == ItemType.Food || inventory.Container[i].item.type == ItemType.egg)
                    {
                        obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
                    }
                    itemsDisplayed.Add(inventory.Container[i], obj);

                }

            }
        }

        else if (currentInv == showInv.gears)
        {

            for (int i = 0; i < gearsInventory.Container.Count; i++)
            {

                if (gearsInventory.Container[i].item.type == ItemType.Equipment && !itemsDisplayed.ContainsKey(gearsInventory.Container[i]))
                {
                    var obj = Instantiate(gearsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(gearsInventory.Container[i], obj);

                }

            }

        }
        else if (currentInv == showInv.potions)
        {

            for (int i = 0; i < potionsInventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(potionsInventory.Container[i]))
                {
                    if ((potionsInventory.Container[i].item.type == ItemType.Potion) && potionsInventory.Container[i] != null)
                    {
                        itemsDisplayed[potionsInventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + potionsInventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (potionsInventory.Container[i].item.type == ItemType.Potion)
                    {
                        var obj = Instantiate(potionsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (potionsInventory.Container[i].item.type == ItemType.Potion)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + potionsInventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(potionsInventory.Container[i], obj);

                    }
                }
            }

        }
        else if (currentInv == showInv.materials)
        {

            for (int i = 0; i < materialsInventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(materialsInventory.Container[i]))
                {
                    if ((materialsInventory.Container[i].item.type == ItemType.Materiel) && materialsInventory.Container[i] != null)
                    {
                        itemsDisplayed[materialsInventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + materialsInventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (materialsInventory.Container[i].item.type == ItemType.Materiel)
                    {
                        var obj = Instantiate(materialsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (materialsInventory.Container[i].item.type == ItemType.Materiel)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + materialsInventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(materialsInventory.Container[i], obj);

                    }
                }

            }

        }

        else if (currentInv == showInv.gems)
        {

            for (int i = 0; i < gemsInventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(gemsInventory.Container[i]))
                {
                    if ((gemsInventory.Container[i].item.type == ItemType.Gem) && gemsInventory.Container[i] != null)
                    {
                        itemsDisplayed[gemsInventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + gemsInventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (gemsInventory.Container[i].item.type == ItemType.Gem)
                    {
                        var obj = Instantiate(gemsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (gemsInventory.Container[i].item.type == ItemType.Gem)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + gemsInventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(gemsInventory.Container[i], obj);

                    }
                }

            }

        }

        else if (currentInv == showInv.meats)
        {

            for (int i = 0; i < meatInventory.Container.Count; i++)
            {

                if (itemsDisplayed.ContainsKey(meatInventory.Container[i]))
                {
                    if ((meatInventory.Container[i].item.type == ItemType.fish  || meatInventory.Container[i].item.type == ItemType.Food) && meatInventory.Container[i] != null)
                    {
                        itemsDisplayed[meatInventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = "X" + meatInventory.Container[i].amount.ToString("n0");
                    }
                }

                else
                {
                    if (meatInventory.Container[i].item.type == ItemType.fish || meatInventory.Container[i].item.type == ItemType.Food)
                    {
                        var obj = Instantiate(meatInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                        obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);

                        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                        if (meatInventory.Container[i].item.type == ItemType.fish || meatInventory.Container[i].item.type == ItemType.Food)
                        {
                            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + meatInventory.Container[i].amount.ToString("n0");
                        }
                        itemsDisplayed.Add(meatInventory.Container[i], obj);

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

            for (int i = 0; i < gearsInventory.Container.Count; i++)
            {
                if (gearsInventory.Container[i].item.type == ItemType.Equipment)
                {
                    var obj = Instantiate(gearsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(gearsInventory.Container[i], obj);

                }
            }
        }
        else if (currentInv == showInv.potions)
        {

            for (int i = 0; i < potionsInventory.Container.Count; i++)
            {
                if (potionsInventory.Container[i].item.type == ItemType.Potion)
                {
                    var obj = Instantiate(potionsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(potionsInventory.Container[i], obj);

                }
            }
        }
        else if (currentInv == showInv.materials)
        {

            for (int i = 0; i < materialsInventory.Container.Count; i++)
            {
                if (materialsInventory.Container[i].item.type == ItemType.Materiel)
                {
                    var obj = Instantiate(materialsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(materialsInventory.Container[i], obj);

                }
            }
        }

        else if (currentInv == showInv.gems)
        {

            for (int i = 0; i < gemsInventory.Container.Count; i++)
            {
                if (gemsInventory.Container[i].item.type == ItemType.Gem)
                {
                    var obj = Instantiate(gemsInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(gemsInventory.Container[i], obj);

                }
            }
        }

        else if (currentInv == showInv.meats)
        {

            for (int i = 0; i < meatInventory.Container.Count; i++)
            {
                if (meatInventory.Container[i].item.type == ItemType.fish || meatInventory.Container[i].item.type == ItemType.Food)
                {
                    var obj = Instantiate(meatInventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
                    obj.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
                    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                    itemsDisplayed.Add(meatInventory.Container[i], obj);

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

        fullInventory.SetActive(false);
        gearInventory.SetActive(true);
        materialInventory.SetActive(false);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(false);

        refreshInv = true;
    }
    public void ShowAll()
    {
        currentInv = showInv.full;

        fullInventory.SetActive(true);
        gearInventory.SetActive(false);
        materialInventory.SetActive(false);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(false);

        refreshInv = true;
    }
    public void ShowPotions()
    {
        currentInv = showInv.potions;

        fullInventory.SetActive(false);
        gearInventory.SetActive(false);
        materialInventory.SetActive(false);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(true);

        refreshInv = true;
    }
    public void ShowMaterials()
    {
        currentInv = showInv.materials;

        fullInventory.SetActive(false);
        gearInventory.SetActive(false);
        materialInventory.SetActive(true);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(false);

        refreshInv = true;
    }

    public void ShowGems()
    {
        currentInv = showInv.gems;

        fullInventory.SetActive(false);
        gearInventory.SetActive(false);
        materialInventory.SetActive(false);
        gemInventory.SetActive(true);
        meatsInventory.SetActive(false);
        potionInventory.SetActive(false);

        refreshInv = true;
    }

    public void ShowMeats()
    {
        currentInv = showInv.meats;

        fullInventory.SetActive(false);
        gearInventory.SetActive(false);
        materialInventory.SetActive(false);
        gemInventory.SetActive(false);
        meatsInventory.SetActive(true);
        potionInventory.SetActive(false);

        refreshInv = true;
    }
}

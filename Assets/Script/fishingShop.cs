using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class fishingShop : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject Inv;
    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static bool refreshInv;
    public GameObject panel;

    public Sprite[] fishSprites;
    public Image[] fishSpriteSlot;
    private string input;
    public InputField value;

    public ItemObject[] Fishs;
    public static string currentFish;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (refreshInv)
        {

            itemsDisplayed.Clear();
            GameObject[] fishs = GameObject.FindGameObjectsWithTag("fishIcons");

            foreach (GameObject fish in fishs)
            {
                Destroy(fish);
            }

            CreateDisplay();
            refreshInv = false;

        }
        if (GameController.Fish1Discovered)
        {
            fishSpriteSlot[0].sprite = fishSprites[0];
        }
        if (GameController.Fish2Discovered)
        {
            fishSpriteSlot[1].sprite = fishSprites[1];
        }
        if (GameController.Fish3Discovered)
        {
            fishSpriteSlot[2].sprite = fishSprites[2];
        }
        if (GameController.Fish4Discovered)
        {
            fishSpriteSlot[3].sprite = fishSprites[3];
        }
        if (GameController.Fish5Discovered)
        {
            fishSpriteSlot[4].sprite = fishSprites[4];
        }

    }

    public void CreateDisplay()
    {

        for (int i = 0; i < inventory.Container.Count; i++)
        {

            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            obj.transform.SetParent(GameObject.FindGameObjectWithTag("fishRightSide").transform, false);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
            itemsDisplayed.Add(inventory.Container[i], obj);

        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }

    public void Fish1Sell()
    {
        panel.SetActive(true);
        currentFish = "fish1";
    }

    public void Fish2Sell()
    {
        panel.SetActive(true);
        currentFish = "fish2";
    }

    public void Fish3Sell()
    {
        panel.SetActive(true);
        currentFish = "fish3";
    }

    public void Fish4Sell()
    {
        panel.SetActive(true);
        currentFish = "fish4";
    }

    public void Fish5Sell()
    {
        panel.SetActive(true);
        currentFish = "fish5";
    }

    public void closePanel()
    {
        panel.SetActive(false);
    }
    public void ConfirmButton()
    {
        
        int number = int.Parse(value.text);
        switch (currentFish)
        {

            case "fish1":

                for (int i = 0; i < number; i++)
                {
                    Inv.RemoveItem(Fishs[0]);
                    inventory.RemoveItem(Fishs[0]);
                    Inv.save();
                    inventory.save();
                    Inventory.refreshInv = true;
                    refreshInv = true;
                }
                break;

            case "fish2":

                for (int i = 0; i < number; i++)
                {
                    Inv.RemoveItem(Fishs[1]);
                    inventory.RemoveItem(Fishs[1]);
                    Inv.save();
                    inventory.save();
                    Inventory.refreshInv = true;
                    refreshInv = true;
                }
                break;

            case "fish3":

                for (int i = 0; i < number; i++)
                {
                    Inv.RemoveItem(Fishs[2]);
                    inventory.RemoveItem(Fishs[2]);
                    Inv.save();
                    inventory.save();
                    Inventory.refreshInv = true;
                    refreshInv = true;
                }
                break;

            case "fish4":

                for (int i = 0; i < number; i++)
                {
                    Inv.RemoveItem(Fishs[3]);
                    inventory.RemoveItem(Fishs[3]);
                    Inv.save();
                    inventory.save();
                    Inventory.refreshInv = true;
                    refreshInv = true;
                }
                break;

            case "fish5":

                for (int i = 0; i < number; i++)
                {
                    Inv.RemoveItem(Fishs[4]);
                    inventory.RemoveItem(Fishs[4]);
                    Inv.save();
                    inventory.save();
                    Inventory.refreshInv = true;
                    refreshInv = true;
                }
                break;
        }

        panel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapidaryRightSide : MonoBehaviour
{
    public GameObject rightSideCraft;
    public GameObject rightSideGems;

    public GameObject RedForgeButton;
    public GameObject BlueForgeButton;
    public GameObject YellowForgeButton;
    public GameObject OrangeForgeButton;
    public GameObject GreenForgeButton;

    public Image image;
    public Image craftItem;
  
    public Sprite[] gemSprites;
    public Sprite[] gemStonesSprites;

    private bool item1Found = false;
    private bool item2Found = false;
    private bool item3Found = false;

    public InventoryObject inventory;

    public Text item1;
    public Text item2;
    public Text item3;

    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RedGem()
    {
        RedForgeButton.SetActive(true);
        BlueForgeButton.SetActive(false);
        YellowForgeButton.SetActive(false);
        OrangeForgeButton.SetActive(false);
        GreenForgeButton.SetActive(false);

        image.sprite = gemSprites[0];
        craftItem.sprite = gemStonesSprites[0];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "RedGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void BlueGem()
    {
        RedForgeButton.SetActive(false);
        BlueForgeButton.SetActive(true);
        YellowForgeButton.SetActive(false);
        OrangeForgeButton.SetActive(false);
        GreenForgeButton.SetActive(false);

        image.sprite = gemSprites[1];
        craftItem.sprite = gemStonesSprites[1];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "BlueGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void YellowGem()
    {
        RedForgeButton.SetActive(false);
        BlueForgeButton.SetActive(false);
        YellowForgeButton.SetActive(true);
        OrangeForgeButton.SetActive(false);
        GreenForgeButton.SetActive(false);

        image.sprite = gemSprites[2];
        craftItem.sprite = gemStonesSprites[2];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "YellowGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void OrangeGem()
    {
        RedForgeButton.SetActive(false);
        BlueForgeButton.SetActive(false);
        YellowForgeButton.SetActive(false);
        OrangeForgeButton.SetActive(true);
        GreenForgeButton.SetActive(false);

        image.sprite = gemSprites[3];
        craftItem.sprite = gemStonesSprites[3];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "OrangeGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void GreenGem()
    {
        RedForgeButton.SetActive(false);
        BlueForgeButton.SetActive(false);
        YellowForgeButton.SetActive(false);
        OrangeForgeButton.SetActive(false);
        GreenForgeButton.SetActive(true);

        image.sprite = gemSprites[4];
        craftItem.sprite = gemStonesSprites[4];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "GreenGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }


    public void craftButton()
    {
        rightSideCraft.SetActive(true);
        rightSideGems.SetActive(false);

        RedForgeButton.SetActive(true);
        BlueForgeButton.SetActive(false);
        YellowForgeButton.SetActive(false);
        OrangeForgeButton.SetActive(false);
        GreenForgeButton.SetActive(false);

        image.sprite = gemSprites[0];
        craftItem.sprite = gemStonesSprites[0];

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "RedGemStone")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {

                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {

                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void gemsButton()
    {
        rightSideCraft.SetActive(false);
        rightSideGems.SetActive(true);
    }
}

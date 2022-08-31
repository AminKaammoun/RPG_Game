using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapidaryRightSide : MonoBehaviour
{
    public GameObject rightSideCraft;
    public GameObject rightSideGems;

    public GameObject forgedItem;
    public GameObject forgedItemPosition;

    public GameObject RedForgeButton;
    public GameObject BlueForgeButton;
    public GameObject YellowForgeButton;
    public GameObject OrangeForgeButton;
    public GameObject GreenForgeButton;

    public GameObject forgeEffect;
    public GameObject forgeEffectPosition;

    public GameObject notEnoughMatierlsText;
    public GameObject secondCanvas;

    private Canvas canvas;

    public Image image;
    public Image craftItem;

    public Sprite[] gemSprites;
    public Sprite[] gemStonesSprites;

    private bool item1Found = false;
    private bool item2Found = false;
    private bool item3Found = false;

    public InventoryObject inventory;
    public InventoryObject GemInventory;

    public Text item1;
    public Text item2;
    public Text item3;

    public AudioSource forgeSound;
    public AudioSource ErrorAudio;

    public ItemObject Wood;
    public ItemObject CoalStone;
    public ItemObject RedGemStone;
    public ItemObject RedGemItem;
    public ItemObject BlueGemStone;
    public ItemObject BlueGemItem;
    public ItemObject YellowGemStone;
    public ItemObject YellowGemItem;
    public ItemObject OrangeGemStone;
    public ItemObject OrangeGemItem;
    public ItemObject GreenGemStone;
    public ItemObject GreenGemItem;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    // Update is called once per frame
    void Awake()
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;

                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }


        item1Found = false;
        item2Found = false;
        item3Found = false;
    }

    public void RedGemForge()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "RedGemStone")
            {

                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {


                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {


                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && GameController.coins >= 50000)
        {
            GameController.coins -= 50000;
            Vector3 add = new Vector3(-851.5162f, -187.3226f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = gemSprites[0];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 3; i++)
            {
                inventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 5; i++)
            {
                inventory.RemoveItem(RedGemStone);
            }

            inventory.AddItem(RedGemItem, 1);
            GemInventory.AddItem(RedGemItem, 1);
            GemInventory.save();
            inventory.save();
        }
        else
        {
            ErrorAudio.Play();
            var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(secondCanvas.transform, false);
            Destroy(forgedTxt, 0.5f);
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "RedGemStone")
            {

                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {

                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }
    }

    public void BlueGemForge()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "BlueGemStone")
            {

                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {


                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {


                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && GameController.coins >= 50000)
        {
            GameController.coins -= 50000;
            Vector3 add = new Vector3(-851.5162f, -187.3226f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = gemSprites[1];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 3; i++)
            {
                inventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 5; i++)
            {
                inventory.RemoveItem(BlueGemStone);
            }

            inventory.AddItem(BlueGemItem, 1);
            GemInventory.AddItem(BlueGemItem, 1);
            GemInventory.save();
            inventory.save();
        }
        else
        {
            ErrorAudio.Play();
            var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(secondCanvas.transform, false);
            Destroy(forgedTxt, 0.5f);
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "BlueGemStone")
            {

                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {

                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }
    }

    public void YellowGemForge()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "YellowGemStone")
            {

                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {


                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {


                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && GameController.coins >= 50000)
        {
            GameController.coins -= 50000;
            Vector3 add = new Vector3(-851.5162f, -187.3226f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = gemSprites[2];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 3; i++)
            {
                inventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 5; i++)
            {
                inventory.RemoveItem(YellowGemStone);
            }

            inventory.AddItem(YellowGemItem, 1);
            GemInventory.AddItem(YellowGemItem, 1);
            GemInventory.save();
            inventory.save();
        }
        else
        {
            ErrorAudio.Play();
            var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(secondCanvas.transform, false);
            Destroy(forgedTxt, 0.5f);
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "YellowGemStone")
            {

                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {

                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }
    }

    public void OrangeGemForge()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "OrangeGemStone")
            {

                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {


                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {


                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && GameController.coins >= 50000)
        {
            GameController.coins -= 50000;
            Vector3 add = new Vector3(-851.5162f, -187.3226f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = gemSprites[3];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 3; i++)
            {
                inventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 5; i++)
            {
                inventory.RemoveItem(OrangeGemStone);
            }

            inventory.AddItem(OrangeGemItem, 1);
            GemInventory.AddItem(OrangeGemItem, 1);
            GemInventory.save();
            inventory.save();
        }
        else
        {
            ErrorAudio.Play();
            var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(secondCanvas.transform, false);
            Destroy(forgedTxt, 0.5f);
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "OrangeGemStone")
            {

                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {

                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }
    }

    public void GreenGemForge()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "GreenGemStone")
            {

                if (inventory.Container[i].amount > 4)
                {
                    item1Found = true;
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {


                if (inventory.Container[i].amount > 2)
                {
                    item2Found = true;
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {


                if (inventory.Container[i].amount > 19)
                {
                    item3Found = true;
                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && GameController.coins >= 50000)
        {
            GameController.coins -= 50000;
            Vector3 add = new Vector3(-851.5162f, -187.3226f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = gemSprites[4];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 3; i++)
            {
                inventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 5; i++)
            {
                inventory.RemoveItem(GreenGemStone);
            }

            inventory.AddItem(GreenGemItem, 1);
            GemInventory.AddItem(GreenGemItem, 1);
            GemInventory.save();
            inventory.save();
        }
        else
        {
            ErrorAudio.Play();
            var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(secondCanvas.transform, false);
            Destroy(forgedTxt, 0.5f);
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "GreenGemStone")
            {

                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {

                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }
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
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/5";
                if (inventory.Container[i].amount > 4)
                {

                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/3";
                if (inventory.Container[i].amount > 2)
                {

                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "Wood")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }

        }
        if (!item1Found)
        {
            item1.color = Color.white;
            item1.text = "0/5";
        }
        if (!item2Found)
        {
            item2.color = Color.white;
            item2.text = "0/3";
        }
        if (!item3Found)
        {
            item3.color = Color.white;
            item3.text = "0/20";
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
    }
    public void gemsButton()
    {
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
        rightSideCraft.SetActive(false);
        rightSideGems.SetActive(true);
    }
}

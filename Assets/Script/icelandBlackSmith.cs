using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class icelandBlacksmith : MonoBehaviour
{
    public Image image;
    public Image craft1;
    public Image craft2;
    public Sprite[] sprites;
    public Sprite[] firstItem;
    private Canvas canvas;

    public ItemObject MagicalAutumnIce;
    public ItemObject MagicalFireIce;
    public ItemObject MagicalIceIce;
    public ItemObject MagicalPlantIce;
    public ItemObject MagicalSakuraIce;
    public ItemObject IronStone;
    public ItemObject Wood;
    public ItemObject CoalStone;

    public ItemObject AtkGearLevel20;
    public ItemObject DefGearLevel20;
    public ItemObject HelmetGearLevel20;
    public ItemObject BeltGearLevel20;
    public ItemObject RingGearLevel20;

    public InventoryObject inventory;
    public InventoryObject materialsInventory;
    public InventoryObject gearsInventory;

    public Text item1;
    public Text item2;
    public Text item3;
    public Text item4;
    public Text item5;

    private bool item1Found = false;
    private bool item2Found = false;
    private bool item3Found = false;
    private bool item4Found = false;
    private bool item5Found = false;


    public GameObject SwordForgeButton;
    public GameObject DefForgeButton;
    public GameObject HelmetForgeButton;
    public GameObject BeltForgeButton;
    public GameObject RingForgeButton;

    public GameObject notEnoughMatierlsText;
    public GameObject notEnoughCoinsText;
    public GameObject secondCanvas;

    public GameObject forgeEffect;
    public GameObject forgeEffectPosition;

    public GameObject forgedItem;
    public GameObject forgedItemPosition;

    public AudioSource forgeSound;
    public AudioSource ErrorAudio;



    // Start is called before the first frame update
    public void Start()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    void Awake()
    {
        SwordForgeButton.SetActive(true);
        DefForgeButton.SetActive(false);
        HelmetForgeButton.SetActive(false);
        BeltForgeButton.SetActive(false);
        RingForgeButton.SetActive(false);

        image.sprite = sprites[0];
        craft1.sprite = firstItem[0];
        craft2.sprite = firstItem[1];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sword()
    {
        SwordForgeButton.SetActive(true);
        DefForgeButton.SetActive(false);
        HelmetForgeButton.SetActive(false);
        BeltForgeButton.SetActive(false);
        RingForgeButton.SetActive(false);

        image.sprite = sprites[0];
        craft1.sprite = firstItem[0];
        craft2.sprite = firstItem[1];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

    }
    public void Def()
    {
        SwordForgeButton.SetActive(false);
        DefForgeButton.SetActive(true);
        HelmetForgeButton.SetActive(false);
        BeltForgeButton.SetActive(false);
        RingForgeButton.SetActive(false);

        image.sprite = sprites[1];
        craft1.sprite = firstItem[1];
        craft2.sprite = firstItem[4];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }

            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;
    }
    public void Helmet()
    {
        SwordForgeButton.SetActive(false);
        DefForgeButton.SetActive(false);
        HelmetForgeButton.SetActive(true);
        BeltForgeButton.SetActive(false);
        RingForgeButton.SetActive(false);

        image.sprite = sprites[2];
        craft1.sprite = firstItem[2];
        craft2.sprite = firstItem[0];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;
    }
    public void Belt()
    {
        SwordForgeButton.SetActive(false);
        DefForgeButton.SetActive(false);
        HelmetForgeButton.SetActive(false);
        BeltForgeButton.SetActive(true);
        RingForgeButton.SetActive(false);

        image.sprite = sprites[3];
        craft1.sprite = firstItem[3];
        craft2.sprite = firstItem[2];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalPlantIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }

            }
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }

            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;
    }
    public void Ring()
    {
        SwordForgeButton.SetActive(false);
        DefForgeButton.SetActive(false);
        HelmetForgeButton.SetActive(false);
        BeltForgeButton.SetActive(false);
        RingForgeButton.SetActive(true);

        image.sprite = sprites[4];
        craft1.sprite = firstItem[4];
        craft2.sprite = firstItem[3];

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalPlantIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item3.color = Color.green;
                }
                else
                {
                    item3.color = Color.white;

                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {

                    item4.color = Color.green;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {

                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;
    }
    public void ForgeSword()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalAutumnIce)
            {

                item1Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item2Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;
                    item3Found = true;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {

                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;
                    item4Found = true;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                    item5Found = true;
                }
                else
                {
                    item5.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 500000)
        {
            GameController.coins -= 500000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[0];
            forgeSound.Play();
            inventory.RemoveItem(MagicalAutumnIce);
            inventory.RemoveItem(MagicalIceIce);
            materialsInventory.RemoveItem(MagicalAutumnIce);
            materialsInventory.RemoveItem(MagicalIceIce);
            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.AddItem(AtkGearLevel20, 1);
            inventory.save();


            gearsInventory.AddItem(AtkGearLevel20, 1);
            gearsInventory.save();

            materialsInventory.save();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

        }
        else
        {
            if (GameController.coins >= 500000)
            {
                var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughCoinsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            ErrorAudio.Play();
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;

                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;

                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

    }

    public void ForgeDef()
    {
        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item1Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item2Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;
                    item3Found = true;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {

                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;
                    item4Found = true;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                    item5Found = true;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }



        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 500000)
        {
            GameController.coins -= 500000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[1];
            forgeSound.Play();
            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }
            inventory.RemoveItem(MagicalIceIce);
            inventory.RemoveItem(MagicalSakuraIce);

            materialsInventory.RemoveItem(MagicalIceIce);
            materialsInventory.RemoveItem(MagicalSakuraIce);

            inventory.AddItem(DefGearLevel20, 1);
            gearsInventory.AddItem(DefGearLevel20, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 500000)
            {
                var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughCoinsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            ErrorAudio.Play();
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalIceIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;

                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;

                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
        if (!item1Found)
        {
            item1.text = "0/1";
            item1.color = Color.white;
        }
        if (!item2Found)
        {
            item2.text = "0/1";
            item2.color = Color.white;
        }
        if (!item3Found)
        {
            item3.text = "0/40";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/20";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/40";
            item5.color = Color.white;
        }

    }
    public void ForgeHelmet()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item1Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item2Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;
                    item3Found = true;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {

                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;
                    item4Found = true;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                    item5Found = true;
                }
                else
                {
                    item5.color = Color.white;
                }
            }

        }

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 500000)
        {
            GameController.coins -= 500000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[2];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalFireIce);
            inventory.RemoveItem(MagicalAutumnIce);

            materialsInventory.RemoveItem(MagicalFireIce);
            materialsInventory.RemoveItem(MagicalAutumnIce);

            inventory.AddItem(HelmetGearLevel20, 1);
            gearsInventory.AddItem(HelmetGearLevel20, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 500000)
            {
                var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughCoinsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            ErrorAudio.Play();
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalAutumnIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;

                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;

                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }

    }
    public void ForgeBelt()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalPlantIce)
            {
                item1Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }

            }
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item2Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }

            }
            if (inventory.Container[i].item.name == "CoalStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;
                    item3Found = true;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {

                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;
                    item4Found = true;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                    item5Found = true;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }


        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 500000)
        {
            GameController.coins -= 500000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[3];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalPlantIce);
            inventory.RemoveItem(MagicalFireIce);

            materialsInventory.RemoveItem(MagicalPlantIce);
            materialsInventory.RemoveItem(MagicalFireIce);

            inventory.AddItem(BeltGearLevel20, 1);
            gearsInventory.AddItem(BeltGearLevel20, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 500000)
            {
                var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughCoinsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            ErrorAudio.Play();
        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalPlantIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalFireIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;

                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;

                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }

    }
    public void ForgeRing()
    {

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item1Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item == MagicalPlantIce)
            {
                item2Found = true;

                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;
                    item3Found = true;
                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {

                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;
                    item4Found = true;
                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {

                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                    item5Found = true;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 500000)
        {
            GameController.coins -= 500000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[4];
            forgeSound.Play();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

            for (int i = 0; i < 20; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 40; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalSakuraIce);
            inventory.RemoveItem(MagicalPlantIce);

            materialsInventory.RemoveItem(MagicalSakuraIce);
            materialsInventory.RemoveItem(MagicalPlantIce);

            inventory.AddItem(RingGearLevel20, 1);
            gearsInventory.AddItem(RingGearLevel20, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 500000)
            {
                var forgedTxt = Instantiate(notEnoughMatierlsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughCoinsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(secondCanvas.transform, false);
                Destroy(forgedTxt, 0.5f);
            }
            ErrorAudio.Play();

        }

        item1Found = false;
        item2Found = false;
        item3Found = false;
        item4Found = false;
        item5Found = false;

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == MagicalSakuraIce)
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
                else
                {
                    item1.color = Color.white;
                }
            }
            if (inventory.Container[i].item = MagicalPlantIce)
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
                else
                {
                    item2.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "CoalStone")
            {
                item3Found = true;
                item3.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item3.color = Color.green;

                }
                else
                {
                    item3.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
                {
                    item4.color = Color.green;

                }
                else
                {
                    item4.color = Color.white;
                }
            }
            if (inventory.Container[i].item.name == "IronStone")
            {
                item5Found = true;
                item5.text = inventory.Container[i].amount.ToString() + "/40";
                if (inventory.Container[i].amount > 39)
                {
                    item5.color = Color.green;
                }
                else
                {
                    item5.color = Color.white;
                }
            }
        }
    }
}

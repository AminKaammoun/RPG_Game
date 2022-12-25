using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class beachBlacksmith : MonoBehaviour
{
    public Image image;
    public Image craft1;
    public Image craft2;
    public Sprite[] sprites;
    public Sprite[] firstItem;
    private Canvas canvas;

    public ItemObject MagicalAutumnShell;
    public ItemObject MagicalIceShell;
    public ItemObject MagicalFireShell;
    public ItemObject MagicalPlantShell;
    public ItemObject MagicalSakuraShell;
    public ItemObject IronStone;
    public ItemObject Wood;
    public ItemObject CoalStone;

    public ItemObject AtkGearLevel10;
    public ItemObject DefGearLevel10;
    public ItemObject HelmetGearLevel10;
    public ItemObject BeltGearLevel10;
    public ItemObject RingGearLevel10;

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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item == MagicalSakuraShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalFireShell)
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalPlantShell)
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
            if (inventory.Container[i].item == MagicalFireShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount >9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalSakuraShell)
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
            if (inventory.Container[i].item == MagicalPlantShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item == MagicalIceShell)
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

                if (inventory.Container[i].amount > 19)
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

                if (inventory.Container[i].amount > 9)
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

                if (inventory.Container[i].amount > 19)
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

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 250000)
        {
            GameController.coins -= 250000;
            Vector3 add = new Vector3(-655.4413f, -282.812f, 0f);
            Vector3 add1 = new Vector3(-702.6507f, -303.0973f, 0f);
            var effect = Instantiate(forgeEffect, forgeEffectPosition.transform.position / (canvas.scaleFactor - canvas.scaleFactor / 4) + add1, Quaternion.identity) as GameObject;
            effect.transform.SetParent(forgeEffectPosition.transform, false);

            var forged = Instantiate(forgedItem, forgedItemPosition.transform.position + add, Quaternion.identity) as GameObject;
            forged.transform.SetParent(forgedItemPosition.transform, false);
            Image image = forged.GetComponent<Image>();
            image.sprite = sprites[0];
            forgeSound.Play();
            inventory.RemoveItem(MagicalAutumnShell);
            inventory.RemoveItem(MagicalIceShell);
            materialsInventory.RemoveItem(MagicalAutumnShell);
            materialsInventory.RemoveItem(MagicalIceShell);
            for (int i = 0; i < 10; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.AddItem(AtkGearLevel10, 1);
            inventory.save();


            gearsInventory.AddItem(AtkGearLevel10, 1);
            gearsInventory.save();

            materialsInventory.save();

            Destroy(effect, 1f);
            Destroy(forged, 1.15f);

        }
        else
        {
            if (GameController.coins >= 250000)
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item == MagicalSakuraShell)
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

                if (inventory.Container[i].amount > 19)
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

                if (inventory.Container[i].amount > 9)
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

                if (inventory.Container[i].amount > 19)
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



        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 250000)
        {
            GameController.coins -= 250000;
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

            for (int i = 0; i < 10; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }
            inventory.RemoveItem(MagicalIceShell);
            inventory.RemoveItem(MagicalSakuraShell);

            materialsInventory.RemoveItem(MagicalIceShell);
            materialsInventory.RemoveItem(MagicalSakuraShell);

            inventory.AddItem(DefGearLevel10, 1);
            gearsInventory.AddItem(DefGearLevel10, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 250000)
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
            if (inventory.Container[i].item == MagicalIceShell)
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
            if (inventory.Container[i].item == MagicalSakuraShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            item3.text = "0/20";
            item3.color = Color.white;
        }
        if (!item4Found)
        {
            item4.text = "0/10";
            item4.color = Color.white;
        }
        if (!item5Found)
        {
            item5.text = "0/20";
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
            if (inventory.Container[i].item == MagicalFireShell)
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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

                if (inventory.Container[i].amount > 19)
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

                if (inventory.Container[i].amount > 9)
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

                if (inventory.Container[i].amount > 19)
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

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 250000)
        {
            GameController.coins -= 250000;
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

            for (int i = 0; i < 10; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalFireShell);
            inventory.RemoveItem(MagicalAutumnShell);

            materialsInventory.RemoveItem(MagicalFireShell);
            materialsInventory.RemoveItem(MagicalAutumnShell);

            inventory.AddItem(HelmetGearLevel10, 1);
            gearsInventory.AddItem(HelmetGearLevel10, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 250000)
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
            if (inventory.Container[i].item == MagicalFireShell)
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
            if (inventory.Container[i].item == MagicalAutumnShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            if (inventory.Container[i].item == MagicalPlantShell)
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
            if (inventory.Container[i].item == MagicalFireShell)
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

                if (inventory.Container[i].amount > 19)
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

                if (inventory.Container[i].amount > 9)
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

                if (inventory.Container[i].amount > 19)
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


        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 250000)
        {
            GameController.coins -= 250000;
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

            for (int i = 0; i < 10; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalPlantShell);
            inventory.RemoveItem(MagicalFireShell);

            materialsInventory.RemoveItem(MagicalPlantShell);
            materialsInventory.RemoveItem(MagicalFireShell);

            inventory.AddItem(BeltGearLevel10, 1);
            gearsInventory.AddItem(BeltGearLevel10, 1);
            
            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if (GameController.coins >= 250000)
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
            if (inventory.Container[i].item == MagicalPlantShell)
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
            if (inventory.Container[i].item == MagicalFireShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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
            if (inventory.Container[i].item== MagicalSakuraShell)
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
            if (inventory.Container[i].item == MagicalPlantShell)
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

                if (inventory.Container[i].amount > 19)
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

                if (inventory.Container[i].amount > 9)
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

                if (inventory.Container[i].amount > 19)
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

        if (item1Found && item2Found && item3Found && item4Found && item5Found && GameController.coins >= 250000)
        {
            GameController.coins -= 250000;
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

            for (int i = 0; i < 10; i++)
            {

                inventory.RemoveItem(Wood);
                materialsInventory.RemoveItem(Wood);

            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(CoalStone);
                materialsInventory.RemoveItem(CoalStone);
            }
            for (int i = 0; i < 20; i++)
            {
                inventory.RemoveItem(IronStone);
                materialsInventory.RemoveItem(IronStone);
            }

            inventory.RemoveItem(MagicalSakuraShell);
            inventory.RemoveItem(MagicalPlantShell);

            materialsInventory.RemoveItem(MagicalSakuraShell);
            materialsInventory.RemoveItem(MagicalPlantShell);

            inventory.AddItem(RingGearLevel10, 1);
            gearsInventory.AddItem(RingGearLevel10, 1);

            gearsInventory.save();
            inventory.save();
            materialsInventory.save();
        }
        else
        {
            if(GameController.coins >= 250000)
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
            if (inventory.Container[i].item == MagicalSakuraShell)
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
            if (inventory.Container[i].item = MagicalPlantShell)
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
            if (inventory.Container[i].item.name == "Wood")
            {
                item4Found = true;
                item4.text = inventory.Container[i].amount.ToString() + "/10";
                if (inventory.Container[i].amount > 9)
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
                item5.text = inventory.Container[i].amount.ToString() + "/20";
                if (inventory.Container[i].amount > 19)
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

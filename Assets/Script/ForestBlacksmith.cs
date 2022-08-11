using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ForestBlacksmith : MonoBehaviour
{
    public Image image;
    public Image craft1;
    public Image craft2;
    public Sprite[] sprites;
    public Sprite[] firstItem;

    public ItemObject MagicalAutumnLeaf;
    public ItemObject MagicalIceLeaf;
    public ItemObject MagicalFireLeaf;
    public ItemObject MagicalPlantLeaf;
    public ItemObject MagicalSakuraLeaf;

    public InventoryObject inventory;

    public Text item1;
    public Text item2;

    private bool item1Found = false;
    private bool item2Found = false;

    public GameObject SwordForgeButton;
    public GameObject DefForgeButton;
    public GameObject HelmetForgeButton;
    public GameObject BeltForgeButton;
    public GameObject RingForgeButton;

    // Start is called before the first frame update
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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;

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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
               
            }
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
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
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }
    public void ForgeSword()
    {
        inventory.RemoveItem(MagicalAutumnLeaf);
        inventory.RemoveItem(MagicalIceLeaf);
        inventory.save();
        item1Found = false;
        item2Found = false;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }

    public void ForgeDef()
    {
        inventory.RemoveItem(MagicalIceLeaf);
        inventory.RemoveItem(MagicalSakuraLeaf);
        inventory.save();
        item1Found = false;
        item2Found = false;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }
    public void ForgeHelmet()
    {
        inventory.RemoveItem(MagicalFireLeaf);
        inventory.RemoveItem(MagicalAutumnLeaf);
        inventory.save();
        item1Found = false;
        item2Found = false;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }
    public void ForgeBelt()
    {
        inventory.RemoveItem(MagicalPlantLeaf);
        inventory.RemoveItem(MagicalFireLeaf);
        inventory.save();
        item1Found = false;
        item2Found = false;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }

            }
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }
    public void ForgeRing()
    {
        inventory.RemoveItem(MagicalSakuraLeaf);
        inventory.RemoveItem(MagicalPlantLeaf);
        inventory.save();
        item1Found = false;
        item2Found = false;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item1Found = true;
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item2Found = true;
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
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
        item1Found = false;
        item2Found = false;
    }
}

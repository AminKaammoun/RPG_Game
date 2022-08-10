using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class blacksmith : MonoBehaviour
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

    // Start is called before the first frame update
    void Awake()
    {
        image.sprite = sprites[0];
        craft1.sprite = firstItem[0];
        craft2.sprite = firstItem[1];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sword()
    {
        image.sprite = sprites[0];
        craft1.sprite = firstItem[0];
        craft2.sprite = firstItem[1];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if(inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString()+"/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }
    public void Def()
    {
        image.sprite = sprites[1];
        craft1.sprite = firstItem[1];
        craft2.sprite = firstItem[4];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalIceLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }
    public void Helmet()
    {
        image.sprite = sprites[2];
        craft1.sprite = firstItem[2];
        craft2.sprite = firstItem[0];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalAutumnLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }
    public void Belt()
    {
        image.sprite = sprites[3];
        craft1.sprite = firstItem[3];
        craft2.sprite = firstItem[2];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalFireLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }
    public void Ring()
    {
        image.sprite = sprites[4];
        craft1.sprite = firstItem[4];
        craft2.sprite = firstItem[3];
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.name == "MagicalSakuraLeaf")
            {
                item1.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item1.color = Color.green;
                }
            }
            if (inventory.Container[i].item.name == "MagicalPlantLeaf")
            {
                item2.text = inventory.Container[i].amount.ToString() + "/1";
                if (inventory.Container[i].amount > 0)
                {
                    item2.color = Color.green;
                }
            }
        }
    }

}

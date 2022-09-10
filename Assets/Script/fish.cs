using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{

    private GameObject bonner;
    public ItemObject[] fishs;
    public InventoryObject inventory;

    // Update is called once per frame
    void Start()
    {
        bonner = GameObject.FindGameObjectWithTag("bobber");
    }

    void Update()
    {
        this.gameObject.transform.position = bonner.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (this.gameObject.name == "Fish1(Clone)")
            {
                fishingArea.stopCollecting = true;
                inventory.AddItem(fishs[0], 1);
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish2(Clone)")
            {
                fishingArea.stopCollecting = true;
                inventory.AddItem(fishs[1], 1);
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish3(Clone)")
            {
                fishingArea.stopCollecting = true;
                inventory.AddItem(fishs[2], 1);
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish4(Clone)")
            {
                fishingArea.stopCollecting = true;
                inventory.AddItem(fishs[3], 1);
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish5(Clone)")
            {
                fishingArea.stopCollecting = true;
                inventory.AddItem(fishs[4], 1);
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{

    private GameObject bonner;
    public ItemObject[] fishs;
    public InventoryObject inventory;
    public InventoryObject FishInventory;
    public GameObject[] textPopUps;
    private GameObject player;


    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
                GameController.Fish1Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[0], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[0], 1);
                FishInventory.AddItem(fishs[0], 1);
                inventory.save();
                FishInventory.save();
                Inventory.refreshInv = true;
               Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish2(Clone)")
            {
                GameController.Fish2Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[1], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[1], 1);
                FishInventory.AddItem(fishs[1], 1);
                FishInventory.save();
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish3(Clone)")
            {
                GameController.Fish3Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[2], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[2], 1);
                FishInventory.AddItem(fishs[2], 1);
                inventory.save();
                FishInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish4(Clone)")
            {
                GameController.Fish4Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[3], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[3], 1);
                FishInventory.AddItem(fishs[3], 1);
                inventory.save();
                FishInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish5(Clone)")
            {
                GameController.Fish5Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[4], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[4], 1);
                FishInventory.AddItem(fishs[4], 1);
                FishInventory.save();
                inventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
        }
    }
}

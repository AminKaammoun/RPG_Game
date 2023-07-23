using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{

    private GameObject bonner;
    public ItemObject[] fishs;
    public InventoryObject inventory;
    public InventoryObject FishInventory;
    public InventoryObject MeatInventory;
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
                MeatInventory.AddItem(fishs[0], 1);
                inventory.save();
                FishInventory.save();
                MeatInventory.save();
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
                MeatInventory.AddItem(fishs[1], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
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
                MeatInventory.AddItem(fishs[2], 1);
                inventory.save();
                FishInventory.save();
                MeatInventory.save();
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
                MeatInventory.AddItem(fishs[3], 1);
                inventory.save();
                FishInventory.save();
                MeatInventory.save();
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
                MeatInventory.AddItem(fishs[4], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish6(Clone)")
            {
                GameController.Fish6Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[5], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[5], 1);
                FishInventory.AddItem(fishs[5], 1);
                MeatInventory.AddItem(fishs[5], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish7(Clone)")
            {
                GameController.Fish7Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[6], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[6], 1);
                FishInventory.AddItem(fishs[6], 1);
                MeatInventory.AddItem(fishs[6], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish8(Clone)")
            {
                GameController.Fish8Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[7], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[7], 1);
                FishInventory.AddItem(fishs[7], 1);
                MeatInventory.AddItem(fishs[7], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish9(Clone)")
            {
                GameController.Fish9Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[8], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[8], 1);
                FishInventory.AddItem(fishs[8], 1);
                MeatInventory.AddItem(fishs[8], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "Fish10(Clone)")
            {
                GameController.Fish10Discovered = true;
                fishingArea.stopCollecting = true;
                Instantiate(textPopUps[9], player.transform.position, Quaternion.identity);
                inventory.AddItem(fishs[9], 1);
                FishInventory.AddItem(fishs[9], 1);
                MeatInventory.AddItem(fishs[9], 1);
                FishInventory.save();
                inventory.save();
                MeatInventory.save();
                Inventory.refreshInv = true;
                Destroy(this.gameObject);
            }
        }
    }
}

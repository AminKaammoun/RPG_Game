using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerMap
{
    Village,
    forrest
}

public class GameController : MonoBehaviour
{
   
    public InventoryObject Inv;
    
    public float TimeBtwLeafSpawn;
    public float StartTime = 0.25f ;

    public GameObject inventory;
    public GameObject[] leafSpawner;
    public GameObject alert;
    public GameObject[] panel;
    public GameObject leaf;

    public PlayerMap currentMap;

    public static bool showAlert = false;

    // Start is called before the first frame update
    void Start()
    {
        leafSpawner = GameObject.FindGameObjectsWithTag("LeafSpawner");
    }

    // Update is called once per frame
    void Update()
    {
       
       
        
        panel = GameObject.FindGameObjectsWithTag("panel");

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.SetActive(true);
            Inv.load();
            PlayerMovements.invIsOpen = true;
        }
        if (PlayerMovements.invIsOpen == false)
        {
            inventory.SetActive(false);
        }
        if (showAlert)
        {
            alert.SetActive(true);
        }

        if(currentMap == PlayerMap.forrest)
        {
            if (TimeBtwLeafSpawn <= 0)
            {
                int rand = Random.Range(0, 27);

                Instantiate(leaf, leafSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwLeafSpawn = StartTime;
            }
            else
            {
                TimeBtwLeafSpawn -= Time.deltaTime;
            }

        }
    }
    public void closeInventory()
    {
        Inventory.description = "";
        inventory.SetActive(false);
        Inv.save();
        PlayerMovements.invIsOpen = false;
        foreach (GameObject r in panel)
        {
            r.SetActive(false);
        }

    }
    public void closeAlertButton()
    {
        alert.SetActive(false);
        showAlert = false;
    }
}

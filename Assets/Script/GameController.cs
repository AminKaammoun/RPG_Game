using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject inventory;
    public InventoryObject Inv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.SetActive(true);
            Inv.load();
            PlayerMovements.invIsOpen = true;
        }
   
    
    }
    public void closeInventory()
    {
        inventory.SetActive(false);
        Inv.save();
        PlayerMovements.invIsOpen = false;
    }
   
}

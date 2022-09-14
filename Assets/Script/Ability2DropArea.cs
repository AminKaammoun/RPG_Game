using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ability2DropArea : MonoBehaviour, IDropHandler
{
    public ItemObject[] itemObject;
    public GameObject ability;
    public InventoryObject inventory;
    private bool found = false;
    

    void Update()
    {
        switch (GameController.ability2)
        {
            case "Big Heal Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Big Heal Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                        
                    }
                }
                break;

            case "Small Health Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Small Health Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                break;

            case "Big sheild Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Big sheild Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                break;

            case "Small Shield Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Small Shield Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                break;

            case "Big Speed Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Big Speed Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                break;

            case "Small Speed Potion (potionObject)":
                found = false;
                for (int i = 0; i < inventory.Container.Count; i++)
                {
                    if (inventory.Container[i].item.name == "Small Speed Potion")
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    GameController.ability2 = "";
                    foreach (Transform child in ability.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                break;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            foreach (Transform child in ability.transform)
            {
                Destroy(child.gameObject);
            }

        }

        if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Big Health Potion(Clone)")
        {
            GameController.ability2 = itemObject[0].ToString();
            Ability2Potion.isPlaced = true;

        }
        else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Small Health Potion (Clone)")
        {
            GameController.ability2 = itemObject[1].ToString();
            Ability2Potion.isPlaced = true;
        }
        else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Big Sheild Potion (Clone)")
        {
            GameController.ability2 = itemObject[2].ToString();
            Ability2Potion.isPlaced = true;
        }
        else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Small Sheild Potion(Clone)")
        {
            GameController.ability2 = itemObject[3].ToString();
            Ability2Potion.isPlaced = true;
        }
        else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Big Speed Potion (Clone)")
        {
            GameController.ability2 = itemObject[4].ToString();
            Ability2Potion.isPlaced = true;
        }
        else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "Small Speed Potion(Clone)")
        {
            GameController.ability2 = itemObject[5].ToString();
            Ability2Potion.isPlaced = true;
        }
    }


}

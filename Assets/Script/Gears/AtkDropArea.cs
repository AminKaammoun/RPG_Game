using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AtkDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public ItemObject[] itemObject;

   
    // public GameObject Gear;
    public static int num;
    private string attackGear;

    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {
            
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("attack"))
            {
                
                attackGear = PlayerPrefs.GetString("AttackGear");
                 if (attackGear == "lvl 1 attack (equipmentObject)")
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 5;
                    
                }
                else if (attackGear == "lvl 10 attack (equipmentObject)")
                {
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 50;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 25;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                attackGear = PlayerPrefs.GetString("AttackGear");
                if (attackGear == "lvl 1 attack (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (attackGear == "lvl 10 attack (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }

                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 attack inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 attack inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        PlayerPrefs.SetString("AttackGear", itemObject[0].ToString());
                        break;
                    case 1:
                        PlayerPrefs.SetString("AttackGear", itemObject[1].ToString());

                        break;

                }
                Lapidary.refresh = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();

                AttackGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

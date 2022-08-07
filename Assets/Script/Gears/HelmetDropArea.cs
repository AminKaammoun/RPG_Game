using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelmetDropArea : MonoBehaviour, IDropHandler
{

    public InventoryObject inventory;
    public ItemObject[] itemObject;

    public static int num;
    private string helmetGear;
    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {
           
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("helmet"))
            {

                PlayerPrefs.SetString("HelmetGear", "");
                switch (helmetGear)
                {
                    case "lvl 1 helmet (equipmentObject)":

                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 4;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 8;
                        break;
                    case "lvl 10 helmet (equipmentObject)":

                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 50;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 40;
                        break;
                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                helmetGear = PlayerPrefs.GetString("HelmetGear");
                if (helmetGear == "lvl 1 helmet (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (helmetGear == "lvl 10 helmet (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 helmet inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 helmet inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        PlayerPrefs.SetString("HelmetGear", itemObject[0].ToString());
                        break;
                    case 1:
                        PlayerPrefs.SetString("HelmetGear", itemObject[1].ToString());

                        break;

                }
                //Debug.Log(PlayerPrefs.GetString("AttackGear"));
                //Debug.Log(itemObject.ToString());
                //AtkLevel1.destoryItem = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();

                //Inventory.refreshInv = true;
                //InvDraggableComponent.isPlaced = true;
                HelmetGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}
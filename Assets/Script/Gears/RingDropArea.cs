using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RingDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public ItemObject[] itemObject;

    public static int num;
    private string ringGear;
    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {
           
            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("ring"))
            {
                ringGear = PlayerPrefs.GetString("RingGear");

                switch (ringGear)
                {
                    case "lvl 1 ring (equipmentObject)":

                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 2;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 4;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 2;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 3;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 50;
                        break;
                    case "lvl 10 ring (equipmentObject)":

                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 20;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 250;
                        break;
                }


                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                ringGear = PlayerPrefs.GetString("RingGear");
                if (ringGear == "lvl 1 ring (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (ringGear == "lvl 10 ring (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 ring inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 ring inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        PlayerPrefs.SetString("RingGear", itemObject[0].ToString());
                        break;
                    case 1:
                        PlayerPrefs.SetString("RingGear", itemObject[1].ToString());

                        break;

                }
                //Debug.Log(PlayerPrefs.GetString("AttackGear"));
                //Debug.Log(itemObject.ToString());
                //AtkLevel1.destoryItem = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();
                Lapidary.refresh = true;
                //Inventory.refreshInv = true;
                //InvDraggableComponent.isPlaced = true;
                RingGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DefDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public ItemObject[] itemObject;

    public static int num;
    private string defGear;

    public void OnDrop(PointerEventData eventData)
    {


        if (eventData.pointerDrag != null)
        {
            

            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("def"))
            {
                defGear = PlayerPrefs.GetString("DefGear");
                switch (defGear)
                {
                    case "lvl 1 def (equipmentObject)":

                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 2;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 10;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 2;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 10;
                        break;
                    case "lvl 10 def (equipmentObject)":
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 50;
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 10;
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp - 50;

                        break;
                }

                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                
                if (defGear == "lvl 1 def (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (defGear == "lvl 10 def (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 def inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 def inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        PlayerPrefs.SetString("DefGear", itemObject[0].ToString());
                        break;
                    case 1:
                        PlayerPrefs.SetString("DefGear", itemObject[1].ToString());

                        break;

                }
                //Debug.Log(PlayerPrefs.GetString("AttackGear"));
                //Debug.Log(itemObject.ToString());
                //AtkLevel1.destoryItem = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();

                //Inventory.refreshInv = true;
                //InvDraggableComponent.isPlaced = true;
                DefGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}

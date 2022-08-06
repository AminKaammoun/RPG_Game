using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BeltDropArea : MonoBehaviour, IDropHandler
{
    public InventoryObject inventory;
    public ItemObject[] itemObject;

    public static int num;
    private string beltGear;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            

            if (eventData.pointerDrag.GetComponent<RectTransform>().name.Contains("belt"))
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                beltGear = PlayerPrefs.GetString("BeltGear");
                if (beltGear == "lvl 1 belt (equipmentObject)")
                {
                    inventory.AddItem(itemObject[0], 1);
                    inventory.save();
                }
                else if (beltGear == "lvl 10 belt (equipmentObject)")
                {
                    inventory.AddItem(itemObject[1], 1);
                    inventory.save();
                }
                if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 1 belt inventory(Clone)")
                {
                    num = 0;
                }
                else if (eventData.pointerDrag.GetComponent<RectTransform>().name == "lvl 10 belt inventory(Clone)")
                {
                    num = 1;

                }
                switch (num)
                {
                    case 0:
                        PlayerPrefs.SetString("BeltGear", itemObject[0].ToString());
                        break;
                    case 1:
                        PlayerPrefs.SetString("BeltGear", itemObject[1].ToString());

                        break;

                }
                //Debug.Log(PlayerPrefs.GetString("AttackGear"));
                //Debug.Log(itemObject.ToString());
                //AtkLevel1.destoryItem = true;
                inventory.RemoveItem(itemObject[num]);
                inventory.save();

                //Inventory.refreshInv = true;
                //InvDraggableComponent.isPlaced = true;
                BeltGears.isPlaced = true;
                Vector2 add = new Vector2(-192, -16);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + add;
            }
        }
    }
}
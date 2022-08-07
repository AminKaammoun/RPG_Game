using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelmetGearDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public InventoryObject inventory;
    public ItemObject gear;


    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;
    private string helmetGear;

    private void Awake()
    {

        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Start()
    {
        canvas = GetComponentInParent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isPlaced)
        {
            inventory.AddItem(gear, 1);
            inventory.save();
            
            helmetGear = PlayerPrefs.GetString("HelmetGear");
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
            PlayerPrefs.SetString("HelmetGear", "");
            //AtkLevel1.destoryItem = false;
            Destroy(this.gameObject);
        }


        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;

        StartPosition = transform.position;
    }
}

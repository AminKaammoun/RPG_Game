using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RingGearDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public InventoryObject inventory;
    public ItemObject gear;
     

    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;
    private string ringGear;
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

        rectTransform.anchoredPosition += eventData.delta / (canvas.scaleFactor - canvas.scaleFactor / 4);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isPlaced)
        {
            inventory.AddItem(gear, 1);
            inventory.save();
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
            //AtkLevel1.destoryItem = false;
            PlayerPrefs.SetString("RingGear", "");
            LapidaryLeftSide.refresh = true;
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
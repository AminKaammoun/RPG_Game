using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DefGearDraggabaleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public InventoryObject inventory;
    public ItemObject gear;


    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;
    private string defGear;

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
            DefLevel1.destoryItem = false;
            PlayerPrefs.SetString("DefGear", "");
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

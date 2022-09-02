using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RingGearDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public InventoryObject inventory;
    public InventoryObject GemInventory;
    public ItemObject gear;
     

    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;

    public ItemObject lvl1RedGem;
    public ItemObject lvl1BlueGem;
    public ItemObject lvl1YellowGem;
    public ItemObject lvl1OrangeGem;
    public ItemObject lvl1GreenGem;

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

            switch (GameController.ringRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    inventory.AddItem(lvl1RedGem, 1);
                    GemInventory.AddItem(lvl1RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.ringRedGem = "";
                    PlayerMovements.BonusAttack -= 5;
                    break;
            }

            switch (GameController.ringBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    inventory.AddItem(lvl1BlueGem, 1);
                    GemInventory.AddItem(lvl1BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.ringBlueGem = "";
                    PlayerMovements.BonusDefence -= 5;
                    break;
            }


            switch (GameController.ringYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    inventory.AddItem(lvl1YellowGem, 1);
                    GemInventory.AddItem(lvl1YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.ringYellowGem = "";
                    PlayerMovements.BonusAgility -= 5;
                    break;
            }

            switch (GameController.ringOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    inventory.AddItem(lvl1OrangeGem, 1);
                    GemInventory.AddItem(lvl1OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.ringOrangeGem = "";
                    PlayerMovements.BonusSp -= 5;
                    break;
            }


            switch (GameController.ringGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    inventory.AddItem(lvl1GreenGem, 1);
                    GemInventory.AddItem(lvl1GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.ringGreenGem = "";
                    PlayerMovements.BonusHp -= 25;
                    break;
            }

            switch (GameController.ringGear)
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
            GameController.ringGear = "";
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
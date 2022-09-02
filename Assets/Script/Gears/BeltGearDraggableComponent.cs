using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeltGearDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
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

            switch (GameController.beltRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    inventory.AddItem(lvl1RedGem, 1);
                    GemInventory.AddItem(lvl1RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltRedGem = "";
                    PlayerMovements.BonusAttack -= 5;
                    break;
            }

            switch (GameController.beltBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    inventory.AddItem(lvl1BlueGem, 1);
                    GemInventory.AddItem(lvl1BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltBlueGem = "";
                    PlayerMovements.BonusDefence -= 5;
                    break;
            }


            switch (GameController.beltYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    inventory.AddItem(lvl1YellowGem, 1);
                    GemInventory.AddItem(lvl1YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltYellowGem = "";
                    PlayerMovements.BonusAgility -= 5;
                    break;
            }

            switch (GameController.beltOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    inventory.AddItem(lvl1OrangeGem, 1);
                    GemInventory.AddItem(lvl1OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltOrangeGem = "";
                    PlayerMovements.BonusSp -= 5;
                    break;
            }


            switch (GameController.beltGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    inventory.AddItem(lvl1GreenGem, 1);
                    GemInventory.AddItem(lvl1GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltGreenGem = "";
                    PlayerMovements.BonusHp -= 25;
                    break;
            }

            switch (GameController.beltGear)
            {
                case "lvl 1 belt (equipmentObject)":
                    
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 3;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 6;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 7;
                    break;
                case "lvl 10 belt (equipmentObject)":

                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 30;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 50;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 35;
                    break;
            }
            GameController.beltGear = "";
            LapidaryLeftSide.refresh = true;
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

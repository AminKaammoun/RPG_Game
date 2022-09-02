using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AtkGearDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
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

            switch (GameController.swordRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    inventory.AddItem(lvl1RedGem, 1);
                    GemInventory.AddItem(lvl1RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.swordRedGem = "";
                    PlayerMovements.BonusAttack -= 5;
                    break;
            }

            switch (GameController.swordBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    inventory.AddItem(lvl1BlueGem, 1);
                    GemInventory.AddItem(lvl1BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.swordBlueGem = "";
                    PlayerMovements.BonusDefence -= 5;
                    break;
            }


            switch (GameController.swordYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    inventory.AddItem(lvl1YellowGem, 1);
                    GemInventory.AddItem(lvl1YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.swordYellowGem = "";
                    PlayerMovements.BonusAgility -= 5;
                    break;
            }

            switch (GameController.swordOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    inventory.AddItem(lvl1OrangeGem, 1);
                    GemInventory.AddItem(lvl1OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.swordOrangeGem = "";
                    PlayerMovements.BonusSp -= 5;
                    break;
            }


            switch (GameController.swordGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    inventory.AddItem(lvl1GreenGem, 1);
                    GemInventory.AddItem(lvl1GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.swordGreenGem = "";
                    PlayerMovements.BonusHp -= 25;
                    break;
            }

            switch (GameController.attackGear)
            {
                case "lvl 1 attack (equipmentObject)":

                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 10;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 3;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 2;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 5;


                    break;
                case "lvl 10 attack (equipmentObject)":
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 50;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 25;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
                    break;
            }
            GameController.attackGear = "";
            LapidaryLeftSide.refresh = true;
            AtkLevel1.destoryItem = false;
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

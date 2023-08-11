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
    public InventoryObject gearsInventory;

    public ItemObject gear;

    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;

    public ItemObject lvl1RedGem;
    public ItemObject lvl1BlueGem;
    public ItemObject lvl1YellowGem;
    public ItemObject lvl1OrangeGem;
    public ItemObject lvl1GreenGem;

    public ItemObject lvl2RedGem;
    public ItemObject lvl2BlueGem;
    public ItemObject lvl2YellowGem;
    public ItemObject lvl2OrangeGem;
    public ItemObject lvl2GreenGem;

    public ItemObject lvl3RedGem;
    public ItemObject lvl3BlueGem;
    public ItemObject lvl3YellowGem;
    public ItemObject lvl3OrangeGem;
    public ItemObject lvl3GreenGem;

    public ItemObject lvl4RedGem;
    public ItemObject lvl4BlueGem;
    public ItemObject lvl4YellowGem;
    public ItemObject lvl4OrangeGem;
    public ItemObject lvl4GreenGem;

    public ItemObject lvl5RedGem;
    public ItemObject lvl5BlueGem;
    public ItemObject lvl5YellowGem;
    public ItemObject lvl5OrangeGem;
    public ItemObject lvl5GreenGem;


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

            gearsInventory.AddItem(gear, 1);
            gearsInventory.save();

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
                    GameController.beltAtkGemBonus = 0;
                    break;

                case "lvl2RedGem (gemObject)":

                    inventory.AddItem(lvl2RedGem, 1);
                    GemInventory.AddItem(lvl2RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltRedGem = "";
                    PlayerMovements.BonusAttack -= 15;
                    GameController.beltAtkGemBonus = 0;
                    break;

                case "lvl3RedGem (gemObject)":

                    inventory.AddItem(lvl3RedGem, 1);
                    GemInventory.AddItem(lvl3RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltRedGem = "";
                    PlayerMovements.BonusAttack -= 45;
                    GameController.beltAtkGemBonus = 0;
                    break;

                case "lvl4RedGem (gemObject)":

                    inventory.AddItem(lvl4RedGem, 1);
                    GemInventory.AddItem(lvl4RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltRedGem = "";
                    PlayerMovements.BonusAttack -= 135;
                    GameController.beltAtkGemBonus = 0;
                    break;

                case "lvl5RedGem (gemObject)":

                    inventory.AddItem(lvl5RedGem, 1);
                    GemInventory.AddItem(lvl5RedGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltRedGem = "";
                    PlayerMovements.BonusAttack -= 405;
                    GameController.beltAtkGemBonus = 0;
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
                    GameController.beltDefGemBonus = 0;
                    break;

                case "lvl2BlueGem (gemObject)":
                    inventory.AddItem(lvl2BlueGem, 1);
                    GemInventory.AddItem(lvl2BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltBlueGem = "";
                    PlayerMovements.BonusDefence -= 15;
                    GameController.beltDefGemBonus = 0;
                    break;

                case "lvl3BlueGem (gemObject)":
                    inventory.AddItem(lvl3BlueGem, 1);
                    GemInventory.AddItem(lvl3BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltBlueGem = "";
                    PlayerMovements.BonusDefence -= 45;
                    GameController.beltDefGemBonus = 0;
                    break;

                case "lvl4BlueGem (gemObject)":
                    inventory.AddItem(lvl4BlueGem, 1);
                    GemInventory.AddItem(lvl4BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltBlueGem = "";
                    PlayerMovements.BonusDefence -= 135;
                    GameController.beltDefGemBonus = 0;
                    break;

                case "lvl5BlueGem (gemObject)":
                    inventory.AddItem(lvl5BlueGem, 1);
                    GemInventory.AddItem(lvl5BlueGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltBlueGem = "";
                    PlayerMovements.BonusDefence -= 405;
                    GameController.beltDefGemBonus = 0;
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
                    GameController.beltAgiGemBonus = 0;
                    break;

                case "lvl2YellowGem (gemObject)":
                    inventory.AddItem(lvl2YellowGem, 1);
                    GemInventory.AddItem(lvl2YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltYellowGem = "";
                    PlayerMovements.BonusAgility -= 15;
                    GameController.beltAgiGemBonus = 0;
                    break;

                case "lvl3YellowGem (gemObject)":
                    inventory.AddItem(lvl3YellowGem, 1);
                    GemInventory.AddItem(lvl3YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltYellowGem = "";
                    PlayerMovements.BonusAgility -= 45;
                    GameController.beltAgiGemBonus = 0;
                    break;

                case "lvl4YellowGem (gemObject)":
                    inventory.AddItem(lvl4YellowGem, 1);
                    GemInventory.AddItem(lvl4YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltYellowGem = "";
                    PlayerMovements.BonusAgility -= 135;
                    GameController.beltAgiGemBonus = 0;
                    break;

                case "lvl5YellowGem (gemObject)":
                    inventory.AddItem(lvl5YellowGem, 1);
                    GemInventory.AddItem(lvl5YellowGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltYellowGem = "";
                    PlayerMovements.BonusAgility -= 405;
                    GameController.beltAgiGemBonus = 0;
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
                    GameController.beltSpGemBonus = 0;
                    break;

                case "lvl2OrangeGem (gemObject)":
                    inventory.AddItem(lvl2OrangeGem, 1);
                    GemInventory.AddItem(lvl2OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltOrangeGem = "";
                    PlayerMovements.BonusSp -= 15;
                    GameController.beltSpGemBonus = 0;
                    break;

                case "lvl3OrangeGem (gemObject)":
                    inventory.AddItem(lvl3OrangeGem, 1);
                    GemInventory.AddItem(lvl3OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltOrangeGem = "";
                    PlayerMovements.BonusSp -= 45;
                    GameController.beltSpGemBonus = 0;
                    break;

                case "lvl4OrangeGem (gemObject)":
                    inventory.AddItem(lvl4OrangeGem, 1);
                    GemInventory.AddItem(lvl4OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltOrangeGem = "";
                    PlayerMovements.BonusSp -= 135;
                    GameController.beltSpGemBonus = 0;
                    break;


                case "lvl5OrangeGem (gemObject)":
                    inventory.AddItem(lvl5OrangeGem, 1);
                    GemInventory.AddItem(lvl5OrangeGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltOrangeGem = "";
                    PlayerMovements.BonusSp -= 405;
                    GameController.beltSpGemBonus = 0;
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
                    GameController.beltHpGemBonus = 0;
                    break;

                case "lvl2GreenGem (gemObject)":
                    inventory.AddItem(lvl2GreenGem, 1);
                    GemInventory.AddItem(lvl2GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltGreenGem = "";
                    PlayerMovements.BonusHp -= 75;
                    GameController.beltHpGemBonus = 0;
                    break;

                case "lvl3GreenGem (gemObject)":
                    inventory.AddItem(lvl3GreenGem, 1);
                    GemInventory.AddItem(lvl3GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltGreenGem = "";
                    PlayerMovements.BonusHp -= 225;
                    GameController.beltHpGemBonus = 0;
                    break;

                case "lvl4GreenGem (gemObject)":
                    inventory.AddItem(lvl4GreenGem, 1);
                    GemInventory.AddItem(lvl4GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltGreenGem = "";
                    PlayerMovements.BonusHp -= 675;
                    GameController.beltHpGemBonus = 0;
                    break;

                case "lvl5GreenGem (gemObject)":
                    inventory.AddItem(lvl5GreenGem, 1);
                    GemInventory.AddItem(lvl5GreenGem, 1);
                    inventory.save();
                    GemInventory.save();
                    LapidaryLeftSide.refreshInv = true;
                    Inventory.refreshInv = true;
                    GameController.beltGreenGem = "";
                    PlayerMovements.BonusHp -= 2025;
                    GameController.beltHpGemBonus = 0;
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

                case "lvl 20 belt (equipmentObject)":

                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 75;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 150;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 75;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp - 250;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp - 175;
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

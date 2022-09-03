using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class blueGemDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public ItemObject[] blueGems;

    public InventoryObject inventory;
    public InventoryObject GemInventory;

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
        Destroy(this.gameObject);


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordBlueGem == "lvl1BlueGem (gemObject)")
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
            GameController.swordDefGemBonus = 0;
            inventory.AddItem(blueGems[0], 1);
            GemInventory.AddItem(blueGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldBlueGem == "lvl1BlueGem (gemObject)")
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
            GameController.shieldDefGemBonus = 0;
            inventory.AddItem(blueGems[0], 1);
            GemInventory.AddItem(blueGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetBlueGem == "lvl1BlueGem (gemObject)")
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
            GameController.helmetDefGemBonus = 0;
            inventory.AddItem(blueGems[0], 1);
            GemInventory.AddItem(blueGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltBlueGem == "lvl1BlueGem (gemObject)")
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
            GameController.beltDefGemBonus = 0;
            inventory.AddItem(blueGems[0], 1);
            GemInventory.AddItem(blueGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringBlueGem == "lvl1BlueGem (gemObject)")
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
            GameController.ringDefGemBonus = 0;
            inventory.AddItem(blueGems[0], 1);
            GemInventory.AddItem(blueGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

       



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordBlueGem == "lvl2BlueGem (gemObject)")
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;
            GameController.swordDefGemBonus = 0;

            inventory.AddItem(blueGems[1], 1);
            GemInventory.AddItem(blueGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldBlueGem == "lvl2BlueGem (gemObject)")
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;
            GameController.shieldDefGemBonus = 0;

            inventory.AddItem(blueGems[1], 1);
            GemInventory.AddItem(blueGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetBlueGem == "lvl2BlueGem (gemObject)")
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;
            GameController.helmetDefGemBonus = 0;
            inventory.AddItem(blueGems[1], 1);
            GemInventory.AddItem(blueGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltBlueGem == "lvl2BlueGem (gemObject)")
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;
            GameController.beltDefGemBonus = 0;
            inventory.AddItem(blueGems[1], 1);
            GemInventory.AddItem(blueGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringBlueGem == "lvl2BlueGem (gemObject)")
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 15;
            GameController.ringDefGemBonus = 0;
            inventory.AddItem(blueGems[1], 1);
            GemInventory.AddItem(blueGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordBlueGem == "lvl3BlueGem (gemObject)")
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;
            GameController.swordDefGemBonus = 0; 
            inventory.AddItem(blueGems[2], 1);
            GemInventory.AddItem(blueGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldBlueGem == "lvl3BlueGem (gemObject)")
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;
            GameController.shieldDefGemBonus = 0;
            inventory.AddItem(blueGems[2], 1);
            GemInventory.AddItem(blueGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetBlueGem == "lvl3BlueGem (gemObject)")
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;
            GameController.helmetDefGemBonus = 0;
            inventory.AddItem(blueGems[2], 1);
            GemInventory.AddItem(blueGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltBlueGem == "lvl3BlueGem (gemObject)")
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;
            GameController.beltDefGemBonus = 0;
            inventory.AddItem(blueGems[2], 1);
            GemInventory.AddItem(blueGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringBlueGem == "lvl3BlueGem (gemObject)")
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 45;
            GameController.ringDefGemBonus = 0;
            inventory.AddItem(blueGems[2], 1);
            GemInventory.AddItem(blueGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

       



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordBlueGem == "lvl4BlueGem (gemObject)")
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;
            GameController.swordDefGemBonus = 0;
            inventory.AddItem(blueGems[3], 1);
            GemInventory.AddItem(blueGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;


        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldBlueGem == "lvl4BlueGem (gemObject)")
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;
            GameController.shieldDefGemBonus = 0;
            inventory.AddItem(blueGems[3], 1);
            GemInventory.AddItem(blueGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;


        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetBlueGem == "lvl4BlueGem (gemObject)")
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;
            GameController.helmetDefGemBonus = 0;
            inventory.AddItem(blueGems[3], 1);
            GemInventory.AddItem(blueGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;


        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltBlueGem == "lvl4BlueGem (gemObject)")
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;
            GameController.beltDefGemBonus = 0;
            inventory.AddItem(blueGems[3], 1);
            GemInventory.AddItem(blueGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;


        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringBlueGem == "lvl4BlueGem (gemObject)")
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 135;
            GameController.ringDefGemBonus = 0;
            inventory.AddItem(blueGems[3], 1);
            GemInventory.AddItem(blueGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;


        }




        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordBlueGem == "lvl5BlueGem (gemObject)")
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;
            GameController.swordDefGemBonus = 0;
            inventory.AddItem(blueGems[4], 1);
            GemInventory.AddItem(blueGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldBlueGem == "lvl5BlueGem (gemObject)")
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;
            GameController.shieldDefGemBonus = 0;
            inventory.AddItem(blueGems[4], 1);
            GemInventory.AddItem(blueGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetBlueGem == "lvl5BlueGem (gemObject)")
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;
            GameController.helmetDefGemBonus = 0;
            inventory.AddItem(blueGems[4], 1);
            GemInventory.AddItem(blueGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltBlueGem == "lvl5BlueGem (gemObject)")
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;
            GameController.beltDefGemBonus = 0;
            inventory.AddItem(blueGems[4], 1);
            GemInventory.AddItem(blueGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringBlueGem == "lvl5BlueGem (gemObject)")
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 405;
            GameController.ringDefGemBonus = 0;
            inventory.AddItem(blueGems[4], 1);
            GemInventory.AddItem(blueGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }


    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class orangeGemDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public ItemObject[] orangeGems;

    public InventoryObject inventory;
    public InventoryObject GemInventory;

    void Awake()
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
       
        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordOrangeGem == "lvl1OrangeGem (gemObject)")
        {
            GameController.swordOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
            GameController.swordSpGemBonus = 0;
            inventory.AddItem(orangeGems[0], 1);
            GemInventory.AddItem(orangeGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldOrangeGem == "lvl1OrangeGem (gemObject)")
        {
            GameController.shieldOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
            GameController.shieldSpGemBonus = 0;
            inventory.AddItem(orangeGems[0], 1);
            GemInventory.AddItem(orangeGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetOrangeGem == "lvl1OrangeGem (gemObject)")
        {
            GameController.helmetOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
            GameController.helmetSpGemBonus = 0;
            inventory.AddItem(orangeGems[0], 1);
            GemInventory.AddItem(orangeGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltOrangeGem == "lvl1OrangeGem (gemObject)")
        {
            GameController.beltOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
            GameController.beltSpGemBonus = 0;
            inventory.AddItem(orangeGems[0], 1);
            GemInventory.AddItem(orangeGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringOrangeGem == "lvl1OrangeGem (gemObject)")
        {
            GameController.ringOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 5;
            GameController.ringSpGemBonus = 0;
            inventory.AddItem(orangeGems[0], 1);
            GemInventory.AddItem(orangeGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordOrangeGem == "lvl2OrangeGem (gemObject)")
        {
            GameController.swordOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
            GameController.swordSpGemBonus = 0;
            inventory.AddItem(orangeGems[1], 1);
            GemInventory.AddItem(orangeGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldOrangeGem == "lvl2OrangeGem (gemObject)")
        {
            GameController.shieldOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
            GameController.shieldSpGemBonus = 0;
            inventory.AddItem(orangeGems[1], 1);
            GemInventory.AddItem(orangeGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetOrangeGem == "lvl2OrangeGem (gemObject)")
        {
            GameController.helmetOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
            GameController.helmetSpGemBonus = 0;
            inventory.AddItem(orangeGems[1], 1);
            GemInventory.AddItem(orangeGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltOrangeGem == "lvl2OrangeGem (gemObject)")
        {
            GameController.beltOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
            GameController.beltSpGemBonus = 0;
            inventory.AddItem(orangeGems[1], 1);
            GemInventory.AddItem(orangeGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringOrangeGem == "lvl2OrangeGem (gemObject)")
        {
            GameController.ringOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 15;
            GameController.ringSpGemBonus = 0;
            inventory.AddItem(orangeGems[1], 1);
            GemInventory.AddItem(orangeGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordOrangeGem == "lvl3OrangeGem (gemObject)")
        {
            GameController.swordOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
            GameController.swordSpGemBonus = 0;
            inventory.AddItem(orangeGems[2], 1);
            GemInventory.AddItem(orangeGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldOrangeGem == "lvl3OrangeGem (gemObject)")
        {
            GameController.shieldOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
            GameController.shieldSpGemBonus = 0;
            inventory.AddItem(orangeGems[2], 1);
            GemInventory.AddItem(orangeGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetOrangeGem == "lvl3OrangeGem (gemObject)")
        {
            GameController.helmetOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
            GameController.helmetSpGemBonus = 0;
            inventory.AddItem(orangeGems[2], 1);
            GemInventory.AddItem(orangeGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltOrangeGem == "lvl3OrangeGem (gemObject)")
        {
            GameController.beltOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
            GameController.beltSpGemBonus = 0;
            inventory.AddItem(orangeGems[2], 1);
            GemInventory.AddItem(orangeGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringOrangeGem == "lvl3OrangeGem (gemObject)")
        {
            GameController.ringOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 45;
            GameController.ringSpGemBonus = 0;
            inventory.AddItem(orangeGems[2], 1);
            GemInventory.AddItem(orangeGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordOrangeGem == "lvl4OrangeGem (gemObject)")
        {
            GameController.swordOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
            GameController.swordSpGemBonus = 0;
            inventory.AddItem(orangeGems[3], 1);
            GemInventory.AddItem(orangeGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldOrangeGem == "lvl4OrangeGem (gemObject)")
        {
            GameController.shieldOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
            GameController.shieldSpGemBonus = 0;
            inventory.AddItem(orangeGems[3], 1);
            GemInventory.AddItem(orangeGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetOrangeGem == "lvl4OrangeGem (gemObject)")
        {
            GameController.helmetOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
            GameController.helmetSpGemBonus = 0;
            inventory.AddItem(orangeGems[3], 1);
            GemInventory.AddItem(orangeGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltOrangeGem == "lvl4OrangeGem (gemObject)")
        {
            GameController.beltOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
            GameController.beltSpGemBonus = 0;
            inventory.AddItem(orangeGems[3], 1);
            GemInventory.AddItem(orangeGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringOrangeGem == "lvl4OrangeGem (gemObject)")
        {
            GameController.ringOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 135;
            GameController.ringSpGemBonus = 0;
            inventory.AddItem(orangeGems[3], 1);
            GemInventory.AddItem(orangeGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordOrangeGem == "lvl5OrangeGem (gemObject)")
        {
            GameController.swordOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
            GameController.swordSpGemBonus = 0;
            inventory.AddItem(orangeGems[4], 1);
            GemInventory.AddItem(orangeGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldOrangeGem == "lvl5OrangeGem (gemObject)")
        {
            GameController.shieldOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
            GameController.shieldSpGemBonus = 0;
            inventory.AddItem(orangeGems[4], 1);
            GemInventory.AddItem(orangeGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetOrangeGem == "lvl5OrangeGem (gemObject)")
        {
            GameController.helmetOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
            GameController.helmetSpGemBonus = 0;
            inventory.AddItem(orangeGems[4], 1);
            GemInventory.AddItem(orangeGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltOrangeGem == "lvl5OrangeGem (gemObject)")
        {
            GameController.beltOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
            GameController.beltSpGemBonus = 0;
            inventory.AddItem(orangeGems[4], 1);
            GemInventory.AddItem(orangeGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringOrangeGem == "lvl5OrangeGem (gemObject)")
        {
            GameController.ringOrangeGem = "";
            PlayerMovements.BonusSp = PlayerMovements.BonusSp - 405;
            GameController.ringSpGemBonus = 0;
            inventory.AddItem(orangeGems[4], 1);
            GemInventory.AddItem(orangeGems[4], 1);
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

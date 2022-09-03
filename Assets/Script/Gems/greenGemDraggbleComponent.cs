using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class greenGemDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public ItemObject[] greenGems;

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
        
        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordGreenGem == "lvl1GreenGem (gemObject)")
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
            GameController.swordHpGemBonus = 0;
            inventory.AddItem(greenGems[0], 1);
            GemInventory.AddItem(greenGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldGreenGem == "lvl1GreenGem (gemObject)")
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
            GameController.shieldHpGemBonus = 0;
            inventory.AddItem(greenGems[0], 1);
            GemInventory.AddItem(greenGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetGreenGem == "lvl1GreenGem (gemObject)")
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
            GameController.helmetHpGemBonus = 0;
            inventory.AddItem(greenGems[0], 1);
            GemInventory.AddItem(greenGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltGreenGem == "lvl1GreenGem (gemObject)")
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
            GameController.beltHpGemBonus = 0;
            inventory.AddItem(greenGems[0], 1);
            GemInventory.AddItem(greenGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringGreenGem == "lvl1GreenGem (gemObject)")
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
            GameController.ringHpGemBonus = 0;
            inventory.AddItem(greenGems[0], 1);
            GemInventory.AddItem(greenGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordGreenGem == "lvl2GreenGem (gemObject)")
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
            GameController.swordHpGemBonus = 0;
            inventory.AddItem(greenGems[1], 1);
            GemInventory.AddItem(greenGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldGreenGem == "lvl2GreenGem (gemObject)")
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
            GameController.shieldHpGemBonus = 0;
            inventory.AddItem(greenGems[1], 1);
            GemInventory.AddItem(greenGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetGreenGem == "lvl2GreenGem (gemObject)")
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
            GameController.helmetHpGemBonus = 0;
            inventory.AddItem(greenGems[1], 1);
            GemInventory.AddItem(greenGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltGreenGem == "lvl2GreenGem (gemObject)")
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
            GameController.beltHpGemBonus = 0;
            inventory.AddItem(greenGems[1], 1);
            GemInventory.AddItem(greenGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringGreenGem == "lvl2GreenGem (gemObject)")
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 75;
            GameController.ringHpGemBonus = 0;
            inventory.AddItem(greenGems[1], 1);
            GemInventory.AddItem(greenGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordGreenGem == "lvl3GreenGem (gemObject)")
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
            GameController.swordHpGemBonus = 0;
            inventory.AddItem(greenGems[2], 1);
            GemInventory.AddItem(greenGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldGreenGem == "lvl3GreenGem (gemObject)")
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
            GameController.shieldHpGemBonus = 0;
            inventory.AddItem(greenGems[2], 1);
            GemInventory.AddItem(greenGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetGreenGem == "lvl3GreenGem (gemObject)")
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
            GameController.helmetHpGemBonus = 0;
            inventory.AddItem(greenGems[2], 1);
            GemInventory.AddItem(greenGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltGreenGem == "lvl3GreenGem (gemObject)")
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
            GameController.beltHpGemBonus = 0;
            inventory.AddItem(greenGems[2], 1);
            GemInventory.AddItem(greenGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringGreenGem == "lvl3GreenGem (gemObject)")
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 225;
            GameController.ringHpGemBonus = 0;
            inventory.AddItem(greenGems[2], 1);
            GemInventory.AddItem(greenGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordGreenGem == "lvl4GreenGem (gemObject)")
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
            GameController.swordHpGemBonus = 0;
            inventory.AddItem(greenGems[3], 1);
            GemInventory.AddItem(greenGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldGreenGem == "lvl4GreenGem (gemObject)")
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
            GameController.shieldHpGemBonus = 0;
            inventory.AddItem(greenGems[3], 1);
            GemInventory.AddItem(greenGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetGreenGem == "lvl4GreenGem (gemObject)")
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
            GameController.helmetHpGemBonus = 0;
            inventory.AddItem(greenGems[3], 1);
            GemInventory.AddItem(greenGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltGreenGem == "lvl4GreenGem (gemObject)")
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
            GameController.beltHpGemBonus = 0;
            inventory.AddItem(greenGems[3], 1);
            GemInventory.AddItem(greenGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringGreenGem == "lvl4GreenGem (gemObject)")
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 675;
            GameController.ringHpGemBonus = 0;
            inventory.AddItem(greenGems[3], 1);
            GemInventory.AddItem(greenGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordGreenGem == "lvl5GreenGem (gemObject)")
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
            GameController.swordHpGemBonus = 0;
            inventory.AddItem(greenGems[4], 1);
            GemInventory.AddItem(greenGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldGreenGem == "lvl5GreenGem (gemObject)")
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
            GameController.shieldHpGemBonus = 0;
            inventory.AddItem(greenGems[4], 1);
            GemInventory.AddItem(greenGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetGreenGem == "lvl5GreenGem (gemObject)")
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
            GameController.helmetHpGemBonus = 0;
            inventory.AddItem(greenGems[4], 1);
            GemInventory.AddItem(greenGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltGreenGem == "lvl5GreenGem (gemObject)")
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
            GameController.beltHpGemBonus = 0;
            inventory.AddItem(greenGems[4], 1);
            GemInventory.AddItem(greenGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringGreenGem == "lvl5GreenGem (gemObject)")
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 2025;
            GameController.ringHpGemBonus = 0;
            inventory.AddItem(greenGems[4], 1);
            GemInventory.AddItem(greenGems[4], 1);
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

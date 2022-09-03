using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class yellowGemDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public ItemObject[] yellowGems;

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


        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordYellowGem == "lvl1YellowGem (gemObject)")
        {
            GameController.swordYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;
            GameController.swordAgiGemBonus = 0;
            inventory.AddItem(yellowGems[0], 1);
            GemInventory.AddItem(yellowGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldYellowGem == "lvl1YellowGem (gemObject)")
        {
            GameController.shieldYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;
            GameController.shieldAgiGemBonus = 0;
            inventory.AddItem(yellowGems[0], 1);
            GemInventory.AddItem(yellowGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetYellowGem == "lvl1YellowGem (gemObject)")
        {
            GameController.helmetYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;
            GameController.helmetAgiGemBonus = 0;
            inventory.AddItem(yellowGems[0], 1);
            GemInventory.AddItem(yellowGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltYellowGem == "lvl1YellowGem (gemObject)")
        {
            GameController.beltYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;
            GameController.beltAgiGemBonus = 0;
            inventory.AddItem(yellowGems[0], 1);
            GemInventory.AddItem(yellowGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringYellowGem == "lvl1YellowGem (gemObject)")
        {
            GameController.ringYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 5;
            GameController.ringAgiGemBonus = 0;
            inventory.AddItem(yellowGems[0], 1);
            GemInventory.AddItem(yellowGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordYellowGem == "lvl2YellowGem (gemObject)")
        {
            GameController.swordYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
            GameController.swordAgiGemBonus = 0;
            inventory.AddItem(yellowGems[1], 1);
            GemInventory.AddItem(yellowGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldYellowGem == "lvl2YellowGem (gemObject)")
        {
            GameController.shieldYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
            GameController.shieldAgiGemBonus = 0;
            inventory.AddItem(yellowGems[1], 1);
            GemInventory.AddItem(yellowGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetYellowGem == "lvl2YellowGem (gemObject)")
        {
            GameController.helmetYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
            GameController.helmetAgiGemBonus = 0;
            inventory.AddItem(yellowGems[1], 1);
            GemInventory.AddItem(yellowGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltYellowGem == "lvl2YellowGem (gemObject)")
        {
            GameController.beltYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
            GameController.beltAgiGemBonus = 0;
            inventory.AddItem(yellowGems[1], 1);
            GemInventory.AddItem(yellowGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringYellowGem == "lvl2YellowGem (gemObject)")
        {
            GameController.ringYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 15;
            GameController.ringAgiGemBonus = 0;
            inventory.AddItem(yellowGems[1], 1);
            GemInventory.AddItem(yellowGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }




        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordYellowGem == "lvl3YellowGem (gemObject)")
        {
            GameController.swordYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;
            GameController.swordAgiGemBonus = 0;
            inventory.AddItem(yellowGems[2], 1);
            GemInventory.AddItem(yellowGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldYellowGem == "lvl3YellowGem (gemObject)")
        {
            GameController.shieldYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;
            GameController.shieldAgiGemBonus = 0;
            inventory.AddItem(yellowGems[2], 1);
            GemInventory.AddItem(yellowGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetYellowGem == "lvl3YellowGem (gemObject)")
        {
            GameController.helmetYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;
            GameController.helmetAgiGemBonus = 0;
            inventory.AddItem(yellowGems[2], 1);
            GemInventory.AddItem(yellowGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltYellowGem == "lvl3YellowGem (gemObject)")
        {
            GameController.beltYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;
            GameController.beltAgiGemBonus = 0;
            inventory.AddItem(yellowGems[2], 1);
            GemInventory.AddItem(yellowGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringYellowGem == "lvl3YellowGem (gemObject)")
        {
            GameController.ringYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 45;
            GameController.ringAgiGemBonus = 0;
            inventory.AddItem(yellowGems[2], 1);
            GemInventory.AddItem(yellowGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordYellowGem == "lvl4YellowGem (gemObject)")
        {
            GameController.swordYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;
            GameController.swordAgiGemBonus = 0;
            inventory.AddItem(yellowGems[3], 1);
            GemInventory.AddItem(yellowGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldYellowGem == "lvl4YellowGem (gemObject)")
        {
            GameController.shieldYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;
            GameController.shieldAgiGemBonus = 0;
            inventory.AddItem(yellowGems[3], 1);
            GemInventory.AddItem(yellowGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetYellowGem == "lvl4YellowGem (gemObject)")
        {
            GameController.helmetYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;
            GameController.helmetAgiGemBonus = 0;
            inventory.AddItem(yellowGems[3], 1);
            GemInventory.AddItem(yellowGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltYellowGem == "lvl4YellowGem (gemObject)")
        {
            GameController.beltYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;
            GameController.beltAgiGemBonus = 0;
            inventory.AddItem(yellowGems[3], 1);
            GemInventory.AddItem(yellowGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringYellowGem == "lvl4YellowGem (gemObject)")
        {
            GameController.ringYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 135;
            GameController.ringAgiGemBonus = 0;
            inventory.AddItem(yellowGems[3], 1);
            GemInventory.AddItem(yellowGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }




        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordYellowGem == "lvl5YellowGem (gemObject)")
        {
            GameController.swordYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;
            GameController.swordAgiGemBonus = 0;
            inventory.AddItem(yellowGems[4], 1);
            GemInventory.AddItem(yellowGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldYellowGem == "lvl5YellowGem (gemObject)")
        {
            GameController.shieldYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;
            GameController.shieldAgiGemBonus = 0;
            inventory.AddItem(yellowGems[4], 1);
            GemInventory.AddItem(yellowGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetYellowGem == "lvl5YellowGem (gemObject)")
        {
            GameController.helmetYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;
            GameController.helmetAgiGemBonus = 0;
            inventory.AddItem(yellowGems[4], 1);
            GemInventory.AddItem(yellowGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltYellowGem == "lvl5YellowGem (gemObject)")
        {
            GameController.beltYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;
            GameController.beltAgiGemBonus = 0;
            inventory.AddItem(yellowGems[4], 1);
            GemInventory.AddItem(yellowGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringYellowGem == "lvl5YellowGem (gemObject)")
        {
            GameController.ringYellowGem = "";
            PlayerMovements.BonusAgility = PlayerMovements.BonusAgility - 405;
            GameController.ringAgiGemBonus = 0;
            inventory.AddItem(yellowGems[4], 1);
            GemInventory.AddItem(yellowGems[4], 1);
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

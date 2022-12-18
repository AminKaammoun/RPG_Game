using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class redGemDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    public ItemObject[] redGems;

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



        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordRedGem == "lvl1RedGem (gemObject)")
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
            GameController.swordAtkGemBonus = 0;
            inventory.AddItem(redGems[0], 1);
            GemInventory.AddItem(redGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldRedGem == "lvl1RedGem (gemObject)")
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
            GameController.shieldAtkGemBonus = 0;
            inventory.AddItem(redGems[0], 1);
            GemInventory.AddItem(redGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetRedGem == "lvl1RedGem (gemObject)")
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
            GameController.helmetAtkGemBonus = 0;
            inventory.AddItem(redGems[0], 1);
            GemInventory.AddItem(redGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltRedGem == "lvl1RedGem (gemObject)")
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
            GameController.beltAtkGemBonus = 0;
            inventory.AddItem(redGems[0], 1);
            GemInventory.AddItem(redGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringRedGem == "lvl1RedGem (gemObject)")
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
            GameController.ringAtkGemBonus = 0;
            inventory.AddItem(redGems[0], 1);
            GemInventory.AddItem(redGems[0], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

    

        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordRedGem == "lvl2RedGem (gemObject)")
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
            GameController.swordAtkGemBonus = 0;
            inventory.AddItem(redGems[1], 1);
            GemInventory.AddItem(redGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldRedGem == "lvl2RedGem (gemObject)")
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
            GameController.shieldAtkGemBonus = 0;
            inventory.AddItem(redGems[1], 1);
            GemInventory.AddItem(redGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetRedGem == "lvl2RedGem (gemObject)")
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
            GameController.helmetAtkGemBonus = 0;
            inventory.AddItem(redGems[1], 1);
            GemInventory.AddItem(redGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltRedGem == "lvl2RedGem (gemObject)")
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
            GameController.beltAtkGemBonus = 0;
            inventory.AddItem(redGems[1], 1);
            GemInventory.AddItem(redGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringRedGem == "lvl2RedGem (gemObject)")
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 15;
            GameController.ringAtkGemBonus = 0;
            inventory.AddItem(redGems[1], 1);
            GemInventory.AddItem(redGems[1], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }




        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordRedGem == "lvl3RedGem (gemObject)")
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;
            GameController.swordAtkGemBonus = 0;
            inventory.AddItem(redGems[2], 1);
            GemInventory.AddItem(redGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldRedGem == "lvl3RedGem (gemObject)")
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;
            GameController.shieldAtkGemBonus = 0;
            inventory.AddItem(redGems[2], 1);
            GemInventory.AddItem(redGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetRedGem == "lvl3RedGem (gemObject)")
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;
            GameController.helmetAtkGemBonus = 0;
            inventory.AddItem(redGems[2], 1);
            GemInventory.AddItem(redGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltRedGem == "lvl3RedGem (gemObject)")
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;
            GameController.beltAtkGemBonus = 0;
            inventory.AddItem(redGems[2], 1);
            GemInventory.AddItem(redGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringRedGem == "lvl3RedGem (gemObject)")
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 45;
            GameController.ringAtkGemBonus = 0;
            inventory.AddItem(redGems[2], 1);
            GemInventory.AddItem(redGems[2], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

      

        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordRedGem == "lvl4RedGem (gemObject)")
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;
            GameController.swordAtkGemBonus = 0;
            inventory.AddItem(redGems[3], 1);
            GemInventory.AddItem(redGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldRedGem == "lvl4RedGem (gemObject)")
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;
            GameController.shieldAtkGemBonus = 0;
            inventory.AddItem(redGems[3], 1);
            GemInventory.AddItem(redGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetRedGem == "lvl4RedGem (gemObject)")
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;
            GameController.helmetAtkGemBonus = 0;
            inventory.AddItem(redGems[3], 1);
            GemInventory.AddItem(redGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltRedGem == "lvl4RedGem (gemObject)")
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;
            GameController.beltAtkGemBonus = 0;
            inventory.AddItem(redGems[3], 1);
            GemInventory.AddItem(redGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringRedGem == "lvl4RedGem (gemObject)")
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 135;
            GameController.ringAtkGemBonus = 0;
            inventory.AddItem(redGems[3], 1);
            GemInventory.AddItem(redGems[3], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;

        }




        if (LapidaryLeftSide.currentgear == SelectedGear.sword && GameController.swordRedGem == "lvl5RedGem (gemObject)")
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;
            GameController.swordAtkGemBonus = 0;
            inventory.AddItem(redGems[4], 1);
            GemInventory.AddItem(redGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield && GameController.shieldRedGem == "lvl5RedGem (gemObject)")
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;
            GameController.shieldAtkGemBonus = 0;
            inventory.AddItem(redGems[4], 1);
            GemInventory.AddItem(redGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet && GameController.helmetRedGem == "lvl5RedGem (gemObject)")
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;
            GameController.helmetAtkGemBonus = 0;
            inventory.AddItem(redGems[4], 1);
            GemInventory.AddItem(redGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt && GameController.beltRedGem == "lvl5RedGem (gemObject)")
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;
            GameController.beltAtkGemBonus = 0;
            inventory.AddItem(redGems[4], 1);
            GemInventory.AddItem(redGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring && GameController.ringRedGem == "lvl5RedGem (gemObject)")
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 405;
            GameController.ringAtkGemBonus = 0;
            inventory.AddItem(redGems[4], 1);
            GemInventory.AddItem(redGems[4], 1);
            inventory.save();
            GemInventory.save();
            LapidaryLeftSide.refreshInv = true;
            Inventory.refreshInv = true;
        }

        Destroy(this.gameObject);
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

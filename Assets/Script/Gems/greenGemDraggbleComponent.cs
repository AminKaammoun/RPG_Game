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
        if (LapidaryLeftSide.currentgear == SelectedGear.sword)
        {
            GameController.swordGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
        {
            GameController.shieldGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
        {
            GameController.helmetGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
        {
            GameController.beltGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
        {
            GameController.ringGreenGem = "";
            PlayerMovements.BonusHp = PlayerMovements.BonusHp - 25;
        }

        inventory.AddItem(greenGems[0], 1);
        GemInventory.AddItem(greenGems[0], 1);
        inventory.save();
        GemInventory.save();
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

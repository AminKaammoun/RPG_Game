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
        if (LapidaryLeftSide.currentgear == SelectedGear.sword)
        {
            GameController.swordBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
        {
            GameController.shieldBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
        {
            GameController.helmetBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
        {
            GameController.beltBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
        {
            GameController.ringBlueGem = "";
            PlayerMovements.BonusDefence = PlayerMovements.BonusDefence - 5;
        }

        inventory.AddItem(blueGems[0], 1);
        GemInventory.AddItem(blueGems[0], 1);
        inventory.save();
        GemInventory.save();
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

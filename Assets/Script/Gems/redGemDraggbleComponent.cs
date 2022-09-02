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
       
        if (LapidaryLeftSide.currentgear == SelectedGear.sword)
        {
            GameController.swordRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
           
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
        {
            GameController.shieldRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;

        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
        {
            GameController.helmetRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
        {
            GameController.beltRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
        {
            GameController.ringRedGem = "";
            PlayerMovements.BonusAttack = PlayerMovements.BonusAttack - 5;
        }

        inventory.AddItem(redGems[0], 1);
        GemInventory.AddItem(redGems[0], 1);
        inventory.save();
        GemInventory.save();
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
        Destroy(this.gameObject);
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

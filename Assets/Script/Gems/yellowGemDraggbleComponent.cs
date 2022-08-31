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
        if (LapidaryLeftSide.currentgear == SelectedGear.sword)
        {
            PlayerPrefs.SetString("AttackGearYellowGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
        {
            PlayerPrefs.SetString("DefGearYellowGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
        {
            PlayerPrefs.SetString("HelmetGearYellowGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
        {
            PlayerPrefs.SetString("BeltGearYellowGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
        {
            PlayerPrefs.SetString("RingGearYellowGem", "");
        }

        inventory.AddItem(yellowGems[0], 1);
        GemInventory.AddItem(yellowGems[0], 1);
        inventory.save();
        GemInventory.save();
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

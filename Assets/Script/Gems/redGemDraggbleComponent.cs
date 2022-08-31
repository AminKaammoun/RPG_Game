using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        Destroy(this.gameObject);
        if (LapidaryLeftSide.currentgear == SelectedGear.sword)
        {
            PlayerPrefs.SetString("AttackGearRedGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.shield)
        {
            PlayerPrefs.SetString("DefGearRedGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.helmet)
        {
            PlayerPrefs.SetString("HelmetGearRedGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.belt)
        {
            PlayerPrefs.SetString("BeltGearRedGem", "");
        }
        else if (LapidaryLeftSide.currentgear == SelectedGear.ring)
        {
            PlayerPrefs.SetString("RingGearRedGem", "");
        }

        inventory.AddItem(redGems[0], 1);
        GemInventory.AddItem(redGems[0], 1);
        inventory.save();
        GemInventory.save();
        LapidaryLeftSide.refreshInv = true;
        Inventory.refreshInv = true;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

}

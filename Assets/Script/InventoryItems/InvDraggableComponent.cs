using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InvDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;
    public static Vector3 posi;

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

        posi = transform.position;
        this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("inventory").transform, false);
        transform.position = posi;

    }

    public void OnDrag(PointerEventData eventData)
    {
       
        rectTransform.anchoredPosition += eventData.delta / (canvas.scaleFactor - canvas.scaleFactor / 4);
        

    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (!isPlaced)
        {
            this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("inventoryScrollerSlots").transform, false);
            rectTransform.anchoredPosition = StartPosition;
          
        }


        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
        Vector3 Position = transform.localPosition ;
        StartPosition = Position;
    }

}

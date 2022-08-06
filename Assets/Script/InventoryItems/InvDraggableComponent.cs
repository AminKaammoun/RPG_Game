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
        //isPlaced = false;
        rectTransform.anchoredPosition += eventData.delta / (canvas.scaleFactor - canvas.scaleFactor / 4);


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isPlaced)
        {
            rectTransform.anchoredPosition = StartPosition;
            //Destroy(this.gameObject);
        }


        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
        Vector3 add = new Vector3(-533.33f,-238.87f, 0f) ;
        Vector3 Position = transform.position/ (canvas.scaleFactor - canvas.scaleFactor / 4)+ add;
        
        StartPosition = Position;
    }


}

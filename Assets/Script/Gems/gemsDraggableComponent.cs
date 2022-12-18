using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class gemsDraggableComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    private CanvasGroup canvasGroup;
    public Vector3 StartPosition;

    public static bool isPlaced;
    public static Vector3 posi;
    private GameObject inv;

    private void Awake()
    {
        inv = GameObject.FindGameObjectWithTag("inventory");
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
        try
        {
            if (!inv.activeSelf)
            {
                canvasGroup.alpha = 0.6f;
                canvasGroup.blocksRaycasts = false;

                posi = transform.position;
                this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("lapidary").transform, false);
                transform.position = posi;
            }
        }catch(System.NullReferenceException e)
        {
            canvasGroup.alpha = 0.6f;
            canvasGroup.blocksRaycasts = false;

            posi = transform.position;
            this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("lapidary").transform, false);
            transform.position = posi;
        }
        }

    public void OnDrag(PointerEventData eventData)
    {
        try
        {
            if (!inv.activeSelf)
            {
                rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
            }
        } catch (System.NullReferenceException e) { 

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
        }

    public void OnEndDrag(PointerEventData eventData)
    {
        try
        {
            if (!inv.activeSelf)
            {
                if (!isPlaced)
                {
                    this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("LapidaryRightSide").transform, false);
                    rectTransform.anchoredPosition = StartPosition;

                }


                canvasGroup.blocksRaycasts = true;
                canvasGroup.alpha = 1f;
            }
        }catch(System.NullReferenceException e)
        {
            if (!isPlaced)
            {
                this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("LapidaryRightSide").transform, false);
                rectTransform.anchoredPosition = StartPosition;

            }

            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
        }
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
        Vector3 Position = transform.localPosition;
        StartPosition = Position;
    }

}

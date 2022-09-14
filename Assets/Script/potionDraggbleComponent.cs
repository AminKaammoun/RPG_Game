using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class potionDraggbleComponent : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
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
       // this.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("inventory").transform, false);
        transform.position = posi;

    }

    public void OnDrag(PointerEventData eventData)
    {

        rectTransform.anchoredPosition += eventData.delta / (canvas.scaleFactor - canvas.scaleFactor / 3f);
        

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var parentName = transform.parent.name;
        switch (parentName)
        {
            case "ability1":
                GameController.ability1 = "";
                break;
            case "ability2":
                GameController.ability2 = "";
                break;
            case "ability3":
                GameController.ability3 = "";
                break;
        }
        Destroy(this.gameObject);
       
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
       
    }

}

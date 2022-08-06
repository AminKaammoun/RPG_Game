using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class toolTipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        toolTipSystem.show();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTipSystem.hide();
    }

    
}

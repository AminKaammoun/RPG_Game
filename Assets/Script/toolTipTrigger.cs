using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class toolTipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool Show;
    public GameObject toolTip;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Show = true;
        StartCoroutine(startShow());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.SetActive(false);
        Show = false;
    }

    IEnumerator startShow()
    {
        yield return new WaitForSeconds(0.5f);
        if (Show)
        {
            toolTip.SetActive(true);
        }
    }

} 
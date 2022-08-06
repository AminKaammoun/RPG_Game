using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTip : MonoBehaviour

{

    public RectTransform rectTransform;
    // Start is called before the first frame update
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = Input.mousePosition;
        //float pivotX = position.x / Screen.width;
        //float pivotY = position.y / Screen.height;
        //rectTransform.pivot = new Vector2(pivotX, pivotY);
        transform.position = position;
    }
}

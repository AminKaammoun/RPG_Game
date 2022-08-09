using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTip : MonoBehaviour

{

    public RectTransform rectTransform;
    protected Vector3[] corners;

    
    // Start is called before the first frame update
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        corners = new Vector3[4];
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Input.mousePosition;

        ((RectTransform)transform).GetWorldCorners(corners);
        var width = corners[2].x - corners[0].x;
        var height = corners[1].y - corners[0].y;

        var distPastX = pos.x + width - Screen.width;
        if (distPastX > 0)
            pos = new Vector3(pos.x - distPastX, pos.y, pos.z);
        var distPastY = pos.y - height;
        if (distPastY < 0)
            pos = new Vector3(pos.x, pos.y - distPastY, pos.z);
        transform.position = pos;
    }
}

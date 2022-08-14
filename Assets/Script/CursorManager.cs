using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D PointCursor;
    [SerializeField] private Texture2D NormalCursor;

    private Vector2 cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseOver()
    {
        cursorHotspot = new Vector2(0, -1);
       
        Cursor.SetCursor(PointCursor, cursorHotspot, CursorMode.Auto);
    }
    public void OnMouseExit()
    {
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
}
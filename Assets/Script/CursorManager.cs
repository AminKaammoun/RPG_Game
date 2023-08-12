using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D PointCursor;
    [SerializeField] private Texture2D NormalCursor;
    [SerializeField] private Texture2D BowCursor;

    private Vector2 cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovements.changeCursor)
        {
            if (PlayerMovements.currentWeapon == PlayerWeapon.bow)
            {
                cursorHotspot = new Vector2(BowCursor.width / 2f, BowCursor.height / 2f);
                Cursor.SetCursor(BowCursor, cursorHotspot, CursorMode.Auto);
                PlayerMovements.changeCursor = false;
            }
            else if (PlayerMovements.currentWeapon == PlayerWeapon.sword)
            {
                cursorHotspot = new Vector2(0, -1);
                Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
                PlayerMovements.changeCursor = false;
            }
            else if (PlayerMovements.currentWeapon == PlayerWeapon.rifle)
            {
                cursorHotspot = new Vector2(BowCursor.width / 2f, BowCursor.height / 2f);
                Cursor.SetCursor(BowCursor, cursorHotspot, CursorMode.Auto);
                PlayerMovements.changeCursor = false;
            }
        }
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

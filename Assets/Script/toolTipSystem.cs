using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTipSystem : MonoBehaviour
{

    public static toolTipSystem current;

    public GameObject toolTip;
    // Start is called before the first frame update
    void Awake()
    {
        current = this;
    }

    public static void show()
    {
        current.toolTip.SetActive(true);
    }
    public static void hide()
    {
        current.toolTip.SetActive(false);
    }

    
}

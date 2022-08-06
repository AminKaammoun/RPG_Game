using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefLevel1 : MonoBehaviour
{
    public static bool destoryItem;
    private GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        item = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (destoryItem)
        {
            Destroy(item);

        }
    }
}

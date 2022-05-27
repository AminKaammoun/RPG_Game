using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool[] isFull;
    public GameObject[] slots;

    public GameObject smallHealthPotion;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0 ;i< slots.Length; i++)
        {
            if(isFull[i] == false)
            {
                isFull[i] = true;
                Instantiate(smallHealthPotion, slots[i].transform, false);
                break;
            }
        }
    }
}

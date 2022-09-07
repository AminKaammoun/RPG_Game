using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullGroup : MonoBehaviour
{

    public static GameObject[] logs;
    // Start is called before the first frame update
    void Start()
    {
        logs = GameObject.FindGameObjectsWithTag("log");
        Destroy(this.gameObject, 5f);
    }

  
}

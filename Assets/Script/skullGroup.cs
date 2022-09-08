using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class skullGroup : MonoBehaviour
{
    public static GameObject[] enemies;
    public static GameObject[] logs;
    public static GameObject[] treants;

    // Start is called before the first frame update
    void Start()
    {
        logs = GameObject.FindGameObjectsWithTag("log");
        treants = GameObject.FindGameObjectsWithTag("treant");
        enemies = logs.Concat(treants).ToArray();
        Destroy(this.gameObject, 5f);
    }

  
}

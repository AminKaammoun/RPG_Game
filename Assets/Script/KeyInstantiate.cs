using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInstantiate : MonoBehaviour
{
    public GameObject[] log;
    public GameObject silverKey;
    public GameObject goldKey;

    private GameObject lastLog;

    public int len ;
    public static int silverkeyNumbers = 0;
    public static int goldkeyNumbers = 0;

    // Update is called once per frame
    void Update()
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            log = GameObject.FindGameObjectsWithTag("log");
            len = log.Length;
            if (log.Length == 1)
            {
                lastLog = log[0];
            }

            if (log.Length == 0 && silverkeyNumbers < 1)
            {
                Instantiate(silverKey, lastLog.transform.position, lastLog.transform.rotation);
                silverkeyNumbers++;
            }
        }else if(GameController.currentMap == PlayerMap.forrestDungeon3)
        {
            log = GameObject.FindGameObjectsWithTag("log");
            len = log.Length;
            if (log.Length == 1)
            {
                lastLog = log[0];
            }

            if (log.Length == 0 && goldkeyNumbers < 1)
            {
                Instantiate(goldKey, lastLog.transform.position, lastLog.transform.rotation);
                goldkeyNumbers++;
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInstantiate : MonoBehaviour
{
    public GameObject[] log;
    public GameObject[] treant;
    //public GameObject silverKey;
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
            treant = GameObject.FindGameObjectsWithTag("treant");
            len = log.Length + treant.Length;

            if (len == 1)
            {
                if (log.Length >= 1)
                {
                    lastLog = log[0];
                }
                else
                {
                    lastLog = treant[0];
                }
            }


            if (len == 0 && silverkeyNumbers < 1)
            {
               // Instantiate(silverKey, lastLog.transform.position, lastLog.transform.rotation);
                silverkeyNumbers++;
            }
        }else if(GameController.currentMap == PlayerMap.forrestDungeon3 || GameController.currentMap == PlayerMap.forrestDungeon2nd1 || GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            log = GameObject.FindGameObjectsWithTag("log");
            treant = GameObject.FindGameObjectsWithTag("treant");
            

            len = log.Length + treant.Length;

            if (len == 1)
            {
                if (log.Length >= 1)
                {
                    lastLog = log[0];
                }
                else
                {
                    lastLog = treant[0];
                }
            }

            if (len == 0 && goldkeyNumbers < 1)
            {
                Instantiate(goldKey, lastLog.transform.position, lastLog.transform.rotation);
                goldkeyNumbers++;
            }
            
        }
    }
}

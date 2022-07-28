using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTodun2Lvl1 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public GameObject treant;
    public bool DunLvl2Clear = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.63f, 63.83f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd1;
                if (DunLvl2Clear == false)
                {
                    Instantiate(log, new Vector3(159.02f, 72.16f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(141.06f, 72.03f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(136.93f, 65.78f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(167.41f, 71.88f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(171.79f, 65.43f, 0), Quaternion.identity);
                    Instantiate(treant, new Vector3(148.6f, 72.24f, 0), Quaternion.identity);
                    Instantiate(treant, new Vector3(132.86f, 71.52f, 0), Quaternion.identity);
                    Instantiate(treant, new Vector3(175.55f, 71.61f, 0), Quaternion.identity);
                    DunLvl2Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2nd1)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.63f, 60.99f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;
            }

        }
    }
}

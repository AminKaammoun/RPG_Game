using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDunLvl3 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public bool DunLvl3Clear = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 66.75f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon3;
                if (DunLvl3Clear == false)
                {
                    Instantiate(log, new Vector3(84.52f, 75.73f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(94.47f, 73.91f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(86.52f, 70.78f, 0), Quaternion.identity);
                    DunLvl3Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon3)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 64.15f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDun2Lvl2 : MonoBehaviour
{
    public GameObject player;
    //public GameObject log;
    public bool DunLvl2Clear = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd1)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.63f, 76.9f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd2;
                if (DunLvl2Clear == false)
                {
                    //Instantiate(log, new Vector3(85.04036f, 62.34778f, 0), Quaternion.identity);
                    //Instantiate(log, new Vector3(94.29f, 61.68f, 0), Quaternion.identity);
                    //Instantiate(log, new Vector3(85.56f, 56.54f, 0), Quaternion.identity);
                    //Instantiate(log, new Vector3(102.49f, 62.18f, 0), Quaternion.identity);
                    //Instantiate(log, new Vector3(111.16f, 61.85f, 0), Quaternion.identity);
                    //Instantiate(log, new Vector3(106.99f, 55.66f, 0), Quaternion.identity);
                    DunLvl2Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2nd2)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.63f, 74.1f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd1;
            }

        }
    }
}

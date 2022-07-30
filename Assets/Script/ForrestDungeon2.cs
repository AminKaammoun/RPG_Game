using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestDungeon2 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public GameObject treant;
    public GameObject Cyclop;
    private bool DunLvl2Clear = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Teleport back to forest from Dun 2
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.47f, 50.91f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;
            }
        }

        //Teleport to dun 2
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp1")
            {
                player.transform.position = new Vector3(153.47f, 25.71f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }

        //Teleport from Dun 2 first floor to floor 2
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp2")
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
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp2")
            {
                player.transform.position = new Vector3(153.63f, 60.99f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;
            }

        }

        //Teleport from Dun 2 floor 2 to floor 3
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp3")
            {
                player.transform.position = new Vector3(153.63f, 76.9f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd2;
                if (DunLvl2Clear == false)
                {
                    Instantiate(Cyclop, new Vector3(153.02f, 85.26f, 0), Quaternion.identity);
                    
                    DunLvl2Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2nd2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp3")
            {
                player.transform.position = new Vector3(153.63f, 74.1f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd1;
            }

        }
    }
}

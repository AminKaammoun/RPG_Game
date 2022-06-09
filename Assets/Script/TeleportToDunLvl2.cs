using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDunLvl2 : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 53.78f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 51.53f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon;
            }

        }
    }
}

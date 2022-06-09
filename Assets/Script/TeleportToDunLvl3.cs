using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDunLvl3 : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 66.75f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon3;
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

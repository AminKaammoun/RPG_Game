using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDun2 : MonoBehaviour
{

    public GameObject player;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.47f, 50.91f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;
            }
        }

    }
}
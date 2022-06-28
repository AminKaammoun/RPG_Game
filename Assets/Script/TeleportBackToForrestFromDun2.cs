using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBackToForrestFromDun2 : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(153.47f, 25.71f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBackToForrest : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(89.67f, 20.43f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }
}

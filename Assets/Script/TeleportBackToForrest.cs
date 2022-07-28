using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBackToForrest : MonoBehaviour
{
    public GameObject player;
    public GameObject[] log;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon)
        {
           
            if (collision.CompareTag("Player"))
            {
                log = GameObject.FindGameObjectsWithTag("log");
               
                foreach (GameObject log in log)
                {
                    Destroy(log);
                }
                player.transform.position = new Vector3(89.67f, 20.43f, 0f);
                GameController.currentMap = PlayerMap.forrest;
                TeleportToDunLvl2.DunLvl2Clear = false;
                TeleportToDunLvl3.DunLvl3Clear = false;
                Door1.doorReset = true;
            }
        }
    }
}

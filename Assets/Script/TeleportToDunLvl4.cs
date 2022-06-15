using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDunLvl4 : MonoBehaviour
{
    public GameObject player;
    public GameObject worm;
    
    [SerializeField] public GameObject closer;

    public static bool isclosed = false;

     void Update()
    {
        if (Worm.isdead)
        {
            closer.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player"))
            {
                closer.SetActive(true);
                isclosed = true;
                player.transform.position = new Vector3(106.66f, 66.82f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon4;
                Instantiate(worm, new Vector3(106.21f, 75.64f, 0), Quaternion.identity);
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon4)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(106.66f, 64.71f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }

        }
    }
}

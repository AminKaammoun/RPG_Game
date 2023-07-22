using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class shipArea : MonoBehaviour
{
    public GameObject player;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to trees area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(198.4f, 30.57f, 0f);
                GameController.currentMap = PlayerMap.forrestTreesArea;
            }
        }

        //teleport back from trees area to forrest
        if (GameController.currentMap == PlayerMap.forrestTreesArea)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp1")
            {
                

                player.transform.position = new Vector3(198.4f, 26.41f, 0f);

                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class shipArea : MonoBehaviour
{
    public GameObject player;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the beach to shipoutside
        if (GameController.currentMap == PlayerMap.beach)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "shiptp1")
            {
                player.transform.position = new Vector3(169.58f, 170.7f, 0f);
                GameController.currentMap = PlayerMap.shipOutside;
            }
        }

        //teleport back shipoutside to beach
        if (GameController.currentMap == PlayerMap.shipOutside)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "shiptp")
            {
                

                player.transform.position = new Vector3(169.45f, 165.36f, 0f);

                GameController.currentMap = PlayerMap.beach;
            }
        }
    }

}

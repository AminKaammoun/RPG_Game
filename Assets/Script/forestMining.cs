using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestMining : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to mining area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                PlayerMovements.canMine = true;
                player.transform.position = new Vector3(120.71f, -20.62f, 0f);
                GameController.currentMap = PlayerMap.forrestMiningArea;
            }
        }

        //teleport back from mining area to forrest
        if (GameController.currentMap == PlayerMap.forrestMiningArea)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp1")
            {
                PlayerMovements.canMine = false;
                player.transform.position = new Vector3(119.98f, -6.38f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }

}

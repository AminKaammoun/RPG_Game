using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceDun1 : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //teleport from iceland to dun1
        if (GameController.currentMap == PlayerMap.iceland)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "icelandDun1Teleport")
            {
                // GameController.changeBGS(beachSound, audioSource);
              
                player.transform.position = new Vector3(270.48f, 103.87f, 0f);
                GameController.currentMap = PlayerMap.iceDun1;
            }
        }
    }
    
}

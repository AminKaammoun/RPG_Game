using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class forestTreesAreaTeleporter : MonoBehaviour
{
    public GameObject player;


    public AudioSource audioSource;
    public AudioSource musicSource;

    public AudioClip forestSound;

    public AudioClip forestMusic;
    public AudioClip forestNightAudio;

  
    

   
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to trees area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(198.4f, 30.57f, 0f);
                
            }
        }

        //teleport back from trees area to forrest
        if (GameController.currentMap == PlayerMap.forrestTreesArea)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp1")
            {
                GameController.changeBGM(forestMusic, musicSource);
                if (time.hour >= 5 && time.hour <= 20)
                {
                    GameController.changeBGS(forestSound, audioSource);
                }
                else
                {
                    GameController.changeBGS(forestNightAudio, audioSource);
                }

                player.transform.position = new Vector3(198.4f, 26.41f, 0f);
                
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }

}

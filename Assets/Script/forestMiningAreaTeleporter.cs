using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestMiningAreaTeleporter : MonoBehaviour
{

    public GameObject player;

    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip dunSound;
    public AudioClip forestSound;
    public AudioClip dunMusic;
    public AudioClip forestMusic;
    public AudioClip forestNightAudio;


   
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to mining area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                GameController.changeBGS(dunSound, audioSource);
                GameController.changeBGM(dunMusic, musicSource);

                player.transform.position = new Vector3(120.71f, -20.62f, 0f);
                GameController.currentMap = PlayerMap.forrestMiningArea;
            }
        }

        //teleport back from mining area to forrest
        if (GameController.currentMap == PlayerMap.forrestMiningArea)
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

                player.transform.position = new Vector3(119.98f, -6.38f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }
   
}

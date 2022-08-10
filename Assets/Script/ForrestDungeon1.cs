using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestDungeon1 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public GameObject[] logs;
    public GameObject worm;

    [SerializeField] public GameObject closer;

    public static bool isclosed = false;
    public static bool DunLvl2Clear = false;
    public static bool DunLvl3Clear = false;
    private bool wormIsBeaten = false;


    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip dunSound;
    public AudioClip forestSound;
    public AudioClip dunMusic;
    public AudioClip forestMusic;
    public AudioClip fightMusic;
    public AudioClip forestNightAudio;

    void Update()
    {
        
        if (Worm.isdead)
        {
            wormIsBeaten = true;
            closer.SetActive(false);
        }
        else
        {
            wormIsBeaten = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Teleport from the forest to dun 1
       
        if (GameController.currentMap == PlayerMap.forrest)
        {
           
            if (collision.CompareTag("Player"))
            {
                GameController.changeBGS(dunSound, audioSource);
                GameController.changeBGM(dunMusic, musicSource);
                player.transform.position = new Vector3(89.67f, 41.06f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon;
            }
        }

        //Teleport back to forest from dun 1
        if (GameController.currentMap == PlayerMap.forrestDungeon)
        {
            
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp1")
            {
                logs = GameObject.FindGameObjectsWithTag("log");

                foreach (GameObject log in logs)
                {
                    Destroy(log);
                }
                GameController.changeBGM(forestMusic, musicSource);
                if (time.hour >= 5 && time.hour <= 20)
                {
                    GameController.changeBGS(forestSound, audioSource);
                }
                else
                {
                    GameController.changeBGS(forestNightAudio, audioSource);
                }
                player.transform.position = new Vector3(89.67f, 20.43f, 0f);
                GameController.currentMap = PlayerMap.forrest;

                resetDun1();
            }
        }
        //Teleport from dun 1 first floor to floor 2
        if (GameController.currentMap == PlayerMap.forrestDungeon)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp2")
            {
                GameController.changeBGM(fightMusic, musicSource);
                player.transform.position = new Vector3(89.67f, 53.78f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
                if (DunLvl2Clear == false)
                {
                    Instantiate(log, new Vector3(85.04036f, 62.34778f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(94.29f, 61.68f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(85.56f, 56.54f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(102.49f, 62.18f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(111.16f, 61.85f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(106.99f, 55.66f, 0), Quaternion.identity);
                    DunLvl2Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp2")
            {
                player.transform.position = new Vector3(89.67f, 51.53f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon;
            }

        }
        //Teleport from dun 1 floor 2 to floor 3
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp3")
            {
                player.transform.position = new Vector3(89.67f, 66.75f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon3;
                if (DunLvl3Clear == false)
                {
                    Instantiate(log, new Vector3(84.52f, 75.73f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(94.47f, 73.91f, 0), Quaternion.identity);
                    Instantiate(log, new Vector3(86.52f, 70.78f, 0), Quaternion.identity);
                    DunLvl3Clear = true;
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon3)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp3")
            {
                player.transform.position = new Vector3(89.67f, 64.15f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }

        }
        //Teleport from dun 1 floor 3 to floor 4
        if (GameController.currentMap == PlayerMap.forrestDungeon2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                
                closer.SetActive(true);
                isclosed = true;
                player.transform.position = new Vector3(106.66f, 66.82f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon4;
                if (!wormIsBeaten)
                {
                    Instantiate(worm, new Vector3(106.21f, 75.64f, 0), Quaternion.identity);
                    
                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon4)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                player.transform.position = new Vector3(106.66f, 64.71f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }

        }

    }
    public void resetDun1()
    {
        ForrestDungeon1.DunLvl2Clear = false;
        ForrestDungeon1.DunLvl3Clear = false;
        GameController.silverKeyDoorReset = true;
        GameController.goldKeyDoorReset = true;
        KeyInstantiate.silverkeyNumbers = 0;
        KeyInstantiate.goldkeyNumbers = 0;
        Worm.isdead = false;
        Door1.silverKeyObtained = false;
        Door2.goldKeyObtained = false;
    }
}

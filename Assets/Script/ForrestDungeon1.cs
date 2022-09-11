using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestDungeon1 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public GameObject[] logs;
    public GameObject worm;
    public GameObject[] waves;
    public GameObject goldKey;
    public GameObject door;


    public GameObject closer;
    public GameObject closer2;

    public static bool isclosed = false;
    public static bool wavesAreCleared = false;

    private bool wormIsBeaten = false;
    private bool instantiateEnemys = false;
    private int currentWave = 0;

    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip dunSound;
    public AudioClip forestSound; 
    public AudioClip dunMusic;
    public AudioClip forestMusic;
    public AudioClip fightMusic;
    public AudioClip forestNightAudio;

    private float startTime = 1.5f;
    private float TimeBtwSpawn = 1.5f;

    Vector3 pos;

    private int SpawnedLogs = 0;
    void Update()
    {
        if (Worm.isdead)
        {
            wormIsBeaten = true;
            closer.SetActive(false);
            closer2.SetActive(false);
        }
        else
        {
            wormIsBeaten = false;
        }



        GameObject[] logs = GameObject.FindGameObjectsWithTag("log");
        if (logs.Length == 0 && currentWave != 0 && currentWave < 2)
        {

            StartCoroutine(resetWave());
        }
        if (currentWave == 2 && logs.Length == 1)
        {
            pos = logs[0].transform.position;

        }
        if (currentWave == 2 && logs.Length == 0)
        {
            Instantiate(goldKey, pos, Quaternion.identity);
            currentWave = 0;
        }


        if (instantiateEnemys)
        {

            waves[currentWave].SetActive(true);
            if (SpawnedLogs >= 10)
            {
                instantiateEnemys = false;
                currentWave++;
                SpawnedLogs = 0;

            }

            if (TimeBtwSpawn <= 0)
            {
                int rand = Random.Range(0, 7);
                SpawnedLogs++;
                switch (rand)
                {
                    case 0:
                        Instantiate(log, new Vector3(73.76f, 63.56f, 0), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(log, new Vector3(73.01f, 72.27f, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(log, new Vector3(85.64f, 72.27f, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(log, new Vector3(97.83f, 72.27f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(log, new Vector3(105.41f, 63.56f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(log, new Vector3(105.41f, 54.61f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(log, new Vector3(73.62f, 54.61f, 0), Quaternion.identity);
                        break;
                }
                TimeBtwSpawn = startTime;
            }
            else
            {
                TimeBtwSpawn -= Time.deltaTime;
            }
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
                player.transform.position = new Vector3(89.67f, 53.78f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
                if (!wavesAreCleared)
                {
                    closer2.SetActive(true);
                    GameController.changeBGM(fightMusic, musicSource);
                    instantiateEnemys = true;
                    wavesAreCleared = true;
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
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                GameController.ultValue = 0;
                closer.SetActive(true);
                isclosed = true;
                player.transform.position = new Vector3(89.65f, 74.84f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon3;
                if (!wormIsBeaten)
                {
                    Instantiate(worm, new Vector3(89.12503f, 83.63966f, 0), Quaternion.identity);

                }
            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon3)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                player.transform.position = new Vector3(89.65f, 72.42f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2;
            }

        }

    }
    public void resetDun1()
    {
        wavesAreCleared = false;
        door.SetActive(true);
        waves[0].SetActive(false);
        waves[1].SetActive(false);
        GameController.goldKeyDoorReset = true;
        KeyInstantiate.goldkeyNumbers = 0;
        Worm.isdead = false;
        Door2.goldKeyObtained = false;
    }

    IEnumerator resetWave()
    {

        yield return new WaitForSeconds(2f);
        instantiateEnemys = true;
    }
}

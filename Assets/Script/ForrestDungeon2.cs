using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestDungeon2 : MonoBehaviour
{
    public GameObject player;
    public GameObject log;
    public GameObject[] logs;
    public GameObject[] treants;
    public GameObject[] waves;
    public GameObject treant;
    public GameObject Cyclop;
    public GameObject wall;
    public GameObject wall1;
    public GameObject goldKey;
    public GameObject door;

    public static bool inFight;
    public static bool cyclopIsBeaten = false;

    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip dunSound;
    public AudioClip forestSound;
    public AudioClip dunMusic;
    public AudioClip forestMusic;
    public AudioClip fightMusic;

    private float startTime = 1.5f;
    private float TimeBtwSpawn = 1.5f;

    public static bool wavesAreCleared = false;
    private bool instantiateEnemys = false;
    private int currentWave = 0;
    private int SpawnedLogs = 0;

    Vector3 pos;
    void Update()
    {
        if (inFight)
        {
            wall.SetActive(true);
        }
        else
        {
            wall.SetActive(false);
           
        }
        if (cyclopIsBeaten)
        {
            wall1.SetActive(false);
        }

        GameObject[] logs = GameObject.FindGameObjectsWithTag("log");
        GameObject[] treants = GameObject.FindGameObjectsWithTag("treant");
        if (logs.Length + treants.Length == 0 && currentWave != 0 && currentWave < 2)
        {

            StartCoroutine(resetWave());
        }
        if (currentWave == 2 && logs.Length + treants.Length == 1)
        {
            if (logs.Length == 1)
            {
                pos = logs[0].transform.position;
            }
            else
            {
                pos = treants[0].transform.position;
            }
        }
        if (currentWave == 2 && logs.Length + treants.Length == 0)
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
                int rand = Random.Range(0, 8);
                SpawnedLogs++;
                switch (rand)
                {
                    case 0:
                        Instantiate(log, new Vector3(130.5307f, 64.54595f, 0), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(treant, new Vector3(130.599f, 76.8381f, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(log, new Vector3(130.5307f, 88.45f, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(treant, new Vector3(143.37f, 88.65f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(treant, new Vector3(160.3743f, 88.51565f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(log, new Vector3(176.56f, 87.43f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(treant, new Vector3(176.62f, 76.49f, 0), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(log, new Vector3(176.62f, 64.61f, 0), Quaternion.identity);
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


        //Teleport to dun 2
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                GameController.changeBGS(dunSound, audioSource);
                GameController.changeBGM(dunMusic, musicSource);

                player.transform.position = new Vector3(153.47f, 50.91f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;

            }
        }

        //Teleport back to forest from Dun 2
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp1")
            {
                GameController.changeBGS(forestSound, audioSource);
                GameController.changeBGM(forestMusic, musicSource);
                logs = GameObject.FindGameObjectsWithTag("log");
                foreach (GameObject log in logs)
                {
                    Destroy(log);
                }
                treants = GameObject.FindGameObjectsWithTag("treant");
                foreach (GameObject treant in treants)
                {
                    Destroy(treant);
                }
                player.transform.position = new Vector3(153.47f, 25.71f, 0f);
                GameController.currentMap = PlayerMap.forrest;
                resetDun2();
            }
        }

        //Teleport from Dun 2 first floor to floor 2
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp2")
            {
                GameController.changeBGM(fightMusic, musicSource);
                player.transform.position = new Vector3(153.63f, 63.83f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd1;
               
                if (!wavesAreCleared)
                {
                    wall1.SetActive(true);
                    GameController.changeBGM(fightMusic, musicSource);
                    wavesAreCleared = true;
                    instantiateEnemys = true;
                }
            }
        }


        else if (GameController.currentMap == PlayerMap.forrestDungeon2nd1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp2")
            {
                player.transform.position = new Vector3(153.63f, 60.99f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd;
            }

        }

        //Teleport from Dun 2 floor 2 to floor 3
        if (GameController.currentMap == PlayerMap.forrestDungeon2nd1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp3")
            {
                GameController.ultValue = 0;
                player.transform.position = new Vector3(154.59f, 91.32f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd2;
                if (!cyclopIsBeaten)
                {
                    Instantiate(Cyclop, new Vector3(153.59f, 100.4828f, 0), Quaternion.identity);
                    inFight = true;
                }

            }
        }
        else if (GameController.currentMap == PlayerMap.forrestDungeon2nd2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun2Tp3")
            {
                player.transform.position = new Vector3(154.59f, 89.46f, 0f);
                GameController.currentMap = PlayerMap.forrestDungeon2nd1;
            }

        }
    }
    public void resetDun2()
    {
        wavesAreCleared = false;
        door.SetActive(true);
        GameController.goldKeyDoorReset = true;
        KeyInstantiate.goldkeyNumbers = 0;
        cyclopIsBeaten = false;
        waves[0].SetActive(false);
        waves[1].SetActive(false);
        Door2.goldKeyObtained = false;
    }
    IEnumerator resetWave()
    {

        yield return new WaitForSeconds(2f);
        instantiateEnemys = true;
    }
}

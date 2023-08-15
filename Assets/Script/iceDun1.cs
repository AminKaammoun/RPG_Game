using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class iceDun1 : MonoBehaviour
{
    private GameObject player;
    //public AudioClip dunMusic;
    public AudioClip dunSound;
    public AudioSource audioSource;
    //public AudioSource musicSource;

    public GameObject shardsoul;
    public GameObject golem;

    public static bool wavesAreCleared = false;
    private bool instantiateEnemys = false;
    private int currentWave = 0;
    private int SpawnedLogs = 0;
    Vector3 pos;

    public GameObject[] waves;

    private float startTime = 1.5f;
    private float TimeBtwSpawn = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] shardsouls = GameObject.FindGameObjectsWithTag("shard");
        GameObject[] golems = GameObject.FindGameObjectsWithTag("golem");
        if (shardsouls.Length + golems.Length == 0 && currentWave != 0 && currentWave < 2)
        {

            StartCoroutine(resetWave());
        }
        if (currentWave == 2 && shardsouls.Length + golems.Length == 1)
        {
            if (shardsouls.Length == 1)
            {
                pos = golems[0].transform.position;
            }
            else
            {
                pos = golems[0].transform.position;
            }
        }
        if (currentWave == 2 && shardsouls.Length + golems.Length == 0)
        {
           // Instantiate(goldKey, pos, Quaternion.identity);
            currentWave = 0;
        }


        if (instantiateEnemys)
        {

            waves[currentWave].SetActive(true);
            if (SpawnedLogs >= 25)
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
                        Instantiate(golem, new Vector3(251.39f, 149.5f, 0), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(shardsoul, new Vector3(262.57f, 150.275f, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(golem, new Vector3(286.38f, 149.89f, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(shardsoul, new Vector3(286.95f, 140.36f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(golem, new Vector3(286.73f, 129.06f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(shardsoul, new Vector3(251.76f, 128.61f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(golem, new Vector3(251.322f, 138.67f, 0), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(shardsoul, new Vector3(273.87f, 150.45f, 0), Quaternion.identity);
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
        //teleport from iceland to dun1
        if (GameController.currentMap == PlayerMap.iceland)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "icelandDun1Teleport")
            {
                // GameController.changeBGS(beachSound, audioSource);
                GameController.changeBGS(dunSound, audioSource);
                //GameController.changeBGM(dunMusic, musicSource);
                player.transform.position = new Vector3(270.48f, 103.87f, 0f);
                GameController.currentMap = PlayerMap.iceDun1;
            }
        }
        else if (GameController.currentMap == PlayerMap.iceDun1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "icelandDun1ToDun2")
            {
                player.transform.position = new Vector3(269.2f, 127.78f, 0f);
                GameController.currentMap = PlayerMap.iceDun2;
                if (!wavesAreCleared)
                {
                    //wall1.SetActive(true);
                    //GameController.changeBGM(fightMusic, musicSource);
                    wavesAreCleared = true;
                    instantiateEnemys = true;
                }
            }
        }
    }
    public void resetDun2()
    {
        /*wavesAreCleared = false;
        door.SetActive(true);
        GameController.goldKeyDoorReset = true;
        KeyInstantiate.goldkeyNumbers = 0;
        cyclopIsBeaten = false;
        waves[0].SetActive(false);
        waves[1].SetActive(false);
        Door2.goldKeyObtained = false;*/
    }
    IEnumerator resetWave()
    {

        yield return new WaitForSeconds(2f);
        instantiateEnemys = true;
    }
}

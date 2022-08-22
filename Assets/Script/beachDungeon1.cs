using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beachDungeon1 : MonoBehaviour
{
    public GameObject player;
    public GameObject traps;
    public GameObject Slime;
    public GameObject crab;
    private GameObject[] slimes;
    private GameObject[] crabs;
    public GameObject goldKey;
    public GameObject[] waves;
    public GameObject wall;
    public GameObject wall1;

    public GameObject WaterFallSound;

    public AudioClip dunSound;
    public AudioClip beachSound;
    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip fightMusic;

    private float startTime = 1.5f;
    private float TimeBtwSpawn = 1.5f;

    public static bool wavesAreCleared = false;
    private bool instantiateEnemys = false;
    private int currentWave = 0;
    private int SpawnedLogs = 0;

    Vector3 pos;
    //public static bool DunLvl1Clear = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        GameObject[] crabs = GameObject.FindGameObjectsWithTag("crab");
        GameObject[] slimes = GameObject.FindGameObjectsWithTag("Enemy");
        if (slimes.Length + crabs.Length == 0 && currentWave != 0 && currentWave < 3)
        {

            StartCoroutine(resetWave());
        }
        if (currentWave == 3 && slimes.Length + crabs.Length == 1)
        {
            if (slimes.Length == 1)
            {
                pos = slimes[0].transform.position;
            }
            else
            {
                pos = crabs[0].transform.position;
            }
        }

        if (currentWave == 3 && slimes.Length + crabs.Length == 0)
        {
            Instantiate(goldKey, pos, Quaternion.identity);
            currentWave = 0;
        }


        if (instantiateEnemys)
        {

            waves[currentWave].SetActive(true);
            if (SpawnedLogs >= 15)
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
                        Instantiate(Slime, new Vector3(82.04f, 228.26f, 0), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(crab, new Vector3(81.1f, 218.15f, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Slime, new Vector3(111.71f, 228.26f, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(crab, new Vector3(95.89f, 229.13f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(crab, new Vector3(112.66f, 219.08f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(Slime, new Vector3(108.39f, 206.53f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(crab, new Vector3(96.9f, 207.28f, 0), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(Slime, new Vector3(80.96f, 208.26f, 0), Quaternion.identity);
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
        //Teleport from the beach to dun 1
        if (GameController.currentMap == PlayerMap.beach)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp1")
            {
                GameController.changeBGS(dunSound, audioSource);
                //GameController.changeBGM(dunMusic, musicSource);
                player.transform.position = new Vector3(104.52f, 167.63f, 0f);
                GameController.currentMap = PlayerMap.beachDun;
            }
        }
        //Teleport back from dun to beach
        if (GameController.currentMap == PlayerMap.beachDun && this.gameObject.tag == "Dun1Tp2")
        {
            if (collision.CompareTag("Player"))
            {
                GameController.changeBGS(beachSound, audioSource);
                player.transform.position = new Vector3(104.49f, 149.52f, 0f);
                GameController.currentMap = PlayerMap.beach;
            }
        }
        //Teleport from main to level 1
        if (GameController.currentMap == PlayerMap.beachDun)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp3")
            {
                // GameController.changeBGS(beachSound, audioSource);
                traps.SetActive(true);
                player.transform.position = new Vector3(105.43f, 180.8f, 0f);
                GameController.currentMap = PlayerMap.beachDun1;
            }
        }
        else if (GameController.currentMap == PlayerMap.beachDun1)
        {

            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp3")
            {
                traps.SetActive(false);
                player.transform.position = new Vector3(105.44f, 178.19f, 0f);
                GameController.currentMap = PlayerMap.beachDun;
            }
        }
        //Teleport from Floor 1 to Floor 2
        if (GameController.currentMap == PlayerMap.beachDun1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {

                traps.SetActive(false);
                WaterFallSound.SetActive(true);
                player.transform.position = new Vector3(86.9f, 192.55f, 0f);

                GameController.currentMap = PlayerMap.beachDun2;
            }
        }
        else if (GameController.currentMap == PlayerMap.beachDun2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                WaterFallSound.SetActive(false);
                traps.SetActive(true);
                player.transform.position = new Vector3(86.9f, 190.13f, 0f);
                GameController.currentMap = PlayerMap.beachDun1;
            }
        }

        //Teleport from Floor 2 to Floor 3
        if (GameController.currentMap == PlayerMap.beachDun2)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp5")
            {
                WaterFallSound.SetActive(false);
                player.transform.position = new Vector3(87.5f, 205.63f, 0f);
                wall.SetActive(true);


                if (!wavesAreCleared)
                {
                    //wall1.SetActive(true);
                    GameController.changeBGM(fightMusic, musicSource);
                    musicSource.loop = true;
                    wavesAreCleared = true;
                    instantiateEnemys = true;
                }


                GameController.currentMap = PlayerMap.beachDun3;
            }
        }
        else if (GameController.currentMap == PlayerMap.beachDun3)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp5")
            {
                WaterFallSound.SetActive(true);
                player.transform.position = new Vector3(87.5f, 203.36f, 0f);
                GameController.currentMap = PlayerMap.beachDun2;
            }
        }
       
        //Teleport from Floor 3 to Floor 4
        if (GameController.currentMap == PlayerMap.beachDun3)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp6")
            {
                wall1.SetActive(true);
                player.transform.position = new Vector3(85.52f, 233.95f, 0f);
                GameController.currentMap = PlayerMap.beachDun4;

            }

        }
        else if (GameController.currentMap == PlayerMap.beachDun4)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp6")
            {
                
                player.transform.position = new Vector3(85.52f, 231.37f, 0f);
                GameController.currentMap = PlayerMap.beachDun3;
            }
        }
    }
    public void resetDun1()
    {
        wavesAreCleared = false;
        //door.SetActive(true);
        GameController.goldKeyDoorReset = true;
        KeyInstantiate.goldkeyNumbers = 0;
        //cyclopIsBeaten = false;
        waves[0].SetActive(false);
        waves[1].SetActive(false);
        waves[2].SetActive(false);

        Door2.goldKeyObtained = false;
    }
    IEnumerator resetWave()
    {

        yield return new WaitForSeconds(2f);
        instantiateEnemys = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class WaterDun : MonoBehaviour
{

    public static bool dunCleared = false;
    public static bool instantiateEnemys = false;
    public static bool wavesAreCleared = false;

    Vector3 pos;

    public GameObject goldKey;
    public GameObject[] waves;
  
    public GameObject lightFish;
    public GameObject crab;
    public GameObject jellyFish;

    private int SpawnedLogs = 0;
    private int currentWave = 0;

    private float startTime = 1.5f;
    private float TimeBtwSpawn = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (dunCleared)
        {
          
            dunCleared = false;
        }
        GameObject[] crabs = GameObject.FindGameObjectsWithTag("crab");
        GameObject[] lightFishes = GameObject.FindGameObjectsWithTag("lightFish");
        if (lightFishes.Length + crabs.Length == 0 && currentWave != 0 && currentWave < 3)
        {

            StartCoroutine(resetWave());
        }
        if (currentWave == 3 && lightFishes.Length + crabs.Length == 1)
        {
            if (lightFishes.Length == 1)
            {
                pos = lightFishes[0].transform.position;
            }
            else
            {
                pos = crabs[0].transform.position;
            }
        }

        if (currentWave == 3 && lightFishes.Length + crabs.Length == 0)
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
                        Instantiate(lightFish, new Vector3(212.8376f, 266.5172f, 0), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(jellyFish, new Vector3(212.8376f, 273.18f, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(lightFish, new Vector3(218.59f, 278.29f, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(crab, new Vector3(227.89f, 279.94f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(crab, new Vector3(240.37f, 279.94f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(jellyFish, new Vector3(243.04f, 273.28f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(crab, new Vector3(243.04f, 266.18f, 0), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(lightFish, new Vector3(231.34f, 265.27f, 0), Quaternion.identity);
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

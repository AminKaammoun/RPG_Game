using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestMiningAreaSpawner : MonoBehaviour
{

    private GameObject[] rockSpawnAreas;
    private GameObject[] gemStoneSpawnAreas;
    public GameObject rock;
    public GameObject blueGemStone;
    public GameObject redGemStone;
    public GameObject greenGemStone;
    public GameObject yellowGemStone;
    public GameObject orangeGemStone;

    private bool spawn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.hour == 0)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 1)
        {
            spawn = true;
        }
        if (time.hour == 4)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 5)
        {
            spawn = true;
        }
        if (time.hour == 8)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 9)
        {
            spawn = true;
        }
        if (time.hour == 12)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 13)
        {
            spawn = true;
        }
        if (time.hour == 16)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 17)
        {
            spawn = true;
        }
        if (time.hour == 20)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 21)
        {
            spawn = true;
        }
    }

    public void spawnRock()
    {

        GameObject[] gemStones = GameObject.FindGameObjectsWithTag("gemStone");

        foreach (GameObject gemStone in gemStones)
        {
            Destroy(gemStone);
        }

        GameObject[] rocks = GameObject.FindGameObjectsWithTag("rock");

        foreach (GameObject rock in rocks)
        {
            Destroy(rock);
        }

        gemStoneSpawnAreas = GameObject.FindGameObjectsWithTag("gemStoneSpawnArea");
        rockSpawnAreas = GameObject.FindGameObjectsWithTag("rockSpawnArea");

        foreach (GameObject rockSpawnArea in rockSpawnAreas)
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    Instantiate(rock, rockSpawnArea.transform.position, Quaternion.identity);
                    break;
            }
        }

        foreach (GameObject gemStoneSpawnArea in gemStoneSpawnAreas)
        {

            int rand = Random.Range(0, 20);

            switch (rand)
            {
                case 0:
                    Instantiate(blueGemStone, gemStoneSpawnArea.transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(redGemStone, gemStoneSpawnArea.transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(yellowGemStone, gemStoneSpawnArea.transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(orangeGemStone, gemStoneSpawnArea.transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(greenGemStone, gemStoneSpawnArea.transform.position, Quaternion.identity);
                    break;

            }
        }
    }
}

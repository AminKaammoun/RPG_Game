using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestTreesAreaSpawner : MonoBehaviour
{

    private GameObject[] treesSpawnArea;
    private GameObject[] animalsSpawnArea;
    public GameObject Tree;
    public GameObject goat;
    public GameObject chicken;

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
                spawnTrees();
                spawnAnimals();
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
                spawnTrees();
                spawnAnimals();
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
                spawnTrees();
                spawnAnimals();
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
                spawnTrees();
                spawnAnimals();
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
                spawnTrees();
                spawnAnimals();
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
                spawnTrees();
                spawnAnimals();
                spawn = false;
            }
        }
        if (time.hour == 21)
        {
            spawn = true;
        }
    }
    public void spawnTrees()
    {
        try
        {
            GameObject[] trees = GameObject.FindGameObjectsWithTag("tree");
            GameObject[] leafs = GameObject.FindGameObjectsWithTag("treeAreaLeaf");

            foreach (GameObject tree in trees)
            {
                Destroy(tree);
            }

            foreach (GameObject leaf in leafs)
            {
                Destroy(leaf);
            }
        }
        catch
        {

        }
        treesSpawnArea = GameObject.FindGameObjectsWithTag("treeSpawnArea");

        foreach (GameObject treeSpawnArea in treesSpawnArea)
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    Instantiate(Tree, treeSpawnArea.transform.position, Quaternion.identity);
                    break;
            }
        }
    }
    public void spawnAnimals()
    {
        try
        {
            GameObject[] goats = GameObject.FindGameObjectsWithTag("goat");
            GameObject[] chicken = GameObject.FindGameObjectsWithTag("chicken");
        }
        catch
        {

        }
        animalsSpawnArea = GameObject.FindGameObjectsWithTag("animalSpawnArea");

        foreach (GameObject animalSpawnArea in animalsSpawnArea)
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    Instantiate(goat, animalSpawnArea.transform.position, Quaternion.identity);
                    break;

                case 1:
                    Instantiate(chicken, animalSpawnArea.transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}

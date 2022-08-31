using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestTreesAreaSpawner : MonoBehaviour
{

    private GameObject[] treesSpawnArea;
    public GameObject Tree;

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
}

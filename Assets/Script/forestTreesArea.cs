using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestTreesArea : MonoBehaviour
{
    public GameObject player;
    public GameObject[] treesSpawnArea;
    public GameObject Tree;


    public AudioSource audioSource;
    public AudioSource musicSource;

    public AudioClip forestSound;

    public AudioClip forestMusic;
    public AudioClip forestNightAudio;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to trees area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {


                player.transform.position = new Vector3(198.4f, 30.57f, 0f);
                GameController.currentMap = PlayerMap.forrestTreesArea;
            }
        }

        //teleport back from trees area to forrest
        if (GameController.currentMap == PlayerMap.forrestTreesArea)
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

                player.transform.position = new Vector3(198.4f, 26.41f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }
    public void spawnTrees()
    {
        GameObject[] trees = GameObject.FindGameObjectsWithTag("tree");
        
        foreach(GameObject tree in trees)
        {
            Destroy(tree);
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

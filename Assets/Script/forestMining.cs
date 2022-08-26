using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestMining : MonoBehaviour
{

    public GameObject player;

    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip dunSound;
    public AudioClip forestSound;
    public AudioClip dunMusic;
    public AudioClip forestMusic;
    public AudioClip forestNightAudio;

    public GameObject[] rockSpawnAreas;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        rockSpawnAreas = GameObject.FindGameObjectsWithTag("rockSpawnArea");
        foreach(GameObject rockSpawnArea in rockSpawnAreas)
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    Instantiate(rock, rockSpawnArea.transform.position, Quaternion.identity);
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Teleport from the forest to mining area
        if (GameController.currentMap == PlayerMap.forrest)
        {
            if (collision.CompareTag("Player"))
            {
                GameController.changeBGS(dunSound, audioSource);
                GameController.changeBGM(dunMusic, musicSource);
                PlayerMovements.canMine = true;
                player.transform.position = new Vector3(120.71f, -20.62f, 0f);
                GameController.currentMap = PlayerMap.forrestMiningArea;
            }
        }

        //teleport back from mining area to forrest
        if (GameController.currentMap == PlayerMap.forrestMiningArea)
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
                PlayerMovements.canMine = false;
                player.transform.position = new Vector3(119.98f, -6.38f, 0f);
                GameController.currentMap = PlayerMap.forrest;
            }
        }
    }

}

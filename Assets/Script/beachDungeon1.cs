using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beachDungeon1 : MonoBehaviour
{
    public GameObject player;
    public GameObject traps;

    public AudioClip dunSound;
    public AudioClip beachSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
   

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beachDungeon1 : MonoBehaviour
{
    public GameObject player;
    public GameObject traps;
    public GameObject Slime;
    public GameObject WaterFallSound;

    public AudioClip dunSound;
    public AudioClip beachSound;
    public AudioSource audioSource;

    //public static bool DunLvl1Clear = false;
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
        //Teleport from Floor 1 to Floor 2
        if (GameController.currentMap == PlayerMap.beachDun1)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp4")
            {
                
                traps.SetActive(false);
                WaterFallSound.SetActive(true);
                player.transform.position = new Vector3(86.9f, 192.55f, 0f);
                Instantiate(Slime, new Vector3(81.04f, 194.61f, 0), Quaternion.identity);
                Instantiate(Slime, new Vector3(85.93f, 202.2f, 0), Quaternion.identity);
                Instantiate(Slime, new Vector3(89.37f, 199.66f, 0), Quaternion.identity);
                Instantiate(Slime, new Vector3(80.08f, 198.3104f, 0), Quaternion.identity);
                Instantiate(Slime, new Vector3(94.28f, 194.5f, 0), Quaternion.identity);
                Instantiate(Slime, new Vector3(94.07f, 201.2f, 0), Quaternion.identity);
                GameController.currentMap = PlayerMap.beachDun2;
            }
        }else if (GameController.currentMap == PlayerMap.beachDun2)
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
                GameController.currentMap = PlayerMap.beachDun3;
            }
        }else if (GameController.currentMap == PlayerMap.beachDun3)
        {
            if (collision.CompareTag("Player") && this.gameObject.tag == "Dun1Tp5")
            {
                WaterFallSound.SetActive(true);
                player.transform.position = new Vector3(87.5f, 203.36f, 0f);
                GameController.currentMap = PlayerMap.beachDun2;
            }
        }
    }
}

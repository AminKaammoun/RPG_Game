using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceDun1 : MonoBehaviour
{
    private GameObject player;
    //public AudioClip dunMusic;
    public AudioClip dunSound;
    public AudioSource audioSource;
    //public AudioSource musicSource;
 
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
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
            }
        }
    }
    
}

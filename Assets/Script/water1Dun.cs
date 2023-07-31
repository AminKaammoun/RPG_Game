using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water1Dun : MonoBehaviour
{
    private GameObject player;
    public AudioClip underWaterMusic;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.water1)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(215.52f, 256.29f, 0f);
                GameController.currentMap = PlayerMap.water2;
                GameController.changeBGS(underWaterMusic, audioSource);
                WaterDun.instantiateEnemys = true;

            }
        }
      
    }

}

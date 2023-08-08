using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water1Dun : MonoBehaviour
{
    private GameObject player;
    public AudioClip underWaterMusic;
    public AudioClip beachSound;
    public AudioSource audioSource;
    public AudioSource musicSource;

    public AudioSource gettingUpFromWater;
    public GameObject cacodaemon;
    public AudioClip fightMusic;
   
    public GameObject boxColliderIsland;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.water1 && this.gameObject.tag =="water1ToWater2")
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(215.52f, 256.29f, 0f);
                GameController.currentMap = PlayerMap.water2;
                GameController.changeBGS(underWaterMusic, audioSource);
                WaterDun.instantiateEnemys = true;

            }
        }

        if (GameController.currentMap == PlayerMap.water2 && this.gameObject.tag == "water1ToWater3")
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(220.44f, 290.92f, 0f);
                GameController.currentMap = PlayerMap.water3;
                GameController.changeBGS(beachSound, audioSource);
                StartCoroutine(instantiateEnemey());
                GameController.changeBGM(fightMusic, audioSource);
                PlayerMovements.speed *= 2;
                PlayerMovements.spawnDivingGear = false;
                gettingUpFromWater.Play();
                musicSource.Stop();
               
            }
        }

    }

    IEnumerator instantiateEnemey()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(cacodaemon, new Vector3(232.51f, 299.62f, 0), Quaternion.identity);
        boxColliderIsland.SetActive(true);
    }

}

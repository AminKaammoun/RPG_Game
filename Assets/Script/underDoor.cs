using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class underDoor : MonoBehaviour
{


    private GameObject player;
    public bool playerInRange;
    public GameObject key;  
    public bool keyPressed;
    public GameObject tpPanel;
    public Text loading;
    public AudioSource doorAudio;

    public AudioClip dunSound;
    public AudioClip beachSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
       
}

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && keyPressed == false)
        {

            key.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                tpPanel.SetActive(true); 
                doorAudio.Play();
                StartCoroutine(removeLoadingPanelToShip1());
                //teleport from outsideShip to ship1
                if (GameController.currentMap == PlayerMap.shipOutside)
                {
                    player.transform.position = new Vector3(210.89f, 193.78f, 0f);
                    GameController.changeBGS(dunSound, audioSource);
                    GameController.currentMap = PlayerMap.ship1;
                   
                    //teleport from ship1 to outsideShip
                }else if (GameController.currentMap == PlayerMap.ship1)
                {
                    GameController.changeBGS(beachSound, audioSource);
                    player.transform.position = new Vector3(181.54f, 171.91f, 0f);
                    GameController.currentMap = PlayerMap.shipOutside;
                }
             

            }
            }
            else if (playerInRange && keyPressed == true)
        {
            key.SetActive(false);
            //

        }
        else
        {
            key.SetActive(false);
            //
            keyPressed = false;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    IEnumerator removeLoadingPanelToShip1()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        //GameController.enterLibrary = true;
    }
}

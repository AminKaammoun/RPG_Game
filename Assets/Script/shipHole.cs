using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipHole : MonoBehaviour
{


    private GameObject player;
    public bool playerInRange;
    public GameObject key;
    public bool keyPressed;
    public GameObject tpPanel;
    public Text loading;
    public AudioSource jumpAudio;


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
                jumpAudio.Play();
                StartCoroutine(removeLoadingPanelToShip1());
                //teleport from outsideShip to ship1
                
                if (GameController.currentMap == PlayerMap.ship2)
                {
                    //player.transform.position = new Vector3(204.49f, 192.66f, 0f);

                    //GameController.currentMap = PlayerMap.water1;

                 
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

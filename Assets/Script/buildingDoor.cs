using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildingDoor : MonoBehaviour
{
    public bool playerInRange;
    public GameObject key;
    public bool keyPressed;
    public Text loading;
    private GameObject player;
    public GameObject tpPanel;

    public AudioSource signAudio;
    private GameObject pet;

   
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
                
                
                if (GameController.currentMap == PlayerMap.Village)
                {
                    StartCoroutine(removeLoadingPanelToLibrary());
                    player.transform.position = new Vector3(-43.65f, -32.94f, 0f);
                    try
                    {
                        pet = GameObject.FindGameObjectWithTag("pet");
                        pet.transform.position = new Vector3(-43.65f, -32.94f, 0f);
                    }
                    catch (System.NullReferenceException)
                    {

                        try
                        {
                            pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                            pet = GameObject.FindGameObjectWithTag("eye_Pet");
                            pet = GameObject.FindGameObjectWithTag("crab_Pet");
                            pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                            pet = GameObject.FindGameObjectWithTag("dog_Pet");
                            pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                            pet = GameObject.FindGameObjectWithTag("rock_pet");
                            pet = GameObject.FindGameObjectWithTag("snake_Pet");
                            pet = GameObject.FindGameObjectWithTag("worm_Pet");
                            pet = GameObject.FindGameObjectWithTag("bee_Pet");
                            pet = GameObject.FindGameObjectWithTag("red_dragon");
                            pet.transform.position = new Vector3(-43.65f, -32.94f, 0f);
                        }
                        catch (System.NullReferenceException)
                        {

                        }

                    }
                    GameController.currentMap = PlayerMap.Library;
                    signAudio.Play();
                }else if(GameController.currentMap == PlayerMap.Village1)
                {
                    StartCoroutine(removeLoadingPanelToCastle());
                    player.transform.position = new Vector3(-27.03f, 75.04f, 0f);
                    try
                    {
                        pet = GameObject.FindGameObjectWithTag("pet");
                        pet.transform.position = new Vector3(-27.03f, 75.04f, 0f);
                    }
                    catch (System.NullReferenceException)
                    {

                        try
                        {
                            pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                            pet = GameObject.FindGameObjectWithTag("eye_Pet");
                            pet = GameObject.FindGameObjectWithTag("crab_Pet");
                            pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                            pet = GameObject.FindGameObjectWithTag("dog_Pet");
                            pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                            pet = GameObject.FindGameObjectWithTag("rock_pet");
                            pet = GameObject.FindGameObjectWithTag("snake_Pet");
                            pet = GameObject.FindGameObjectWithTag("worm_Pet");
                            pet = GameObject.FindGameObjectWithTag("bee_Pet");
                            pet = GameObject.FindGameObjectWithTag("red_dragon");
                            pet.transform.position = new Vector3(-43.65f, -32.94f, 0f);
                        }
                        catch (System.NullReferenceException)
                        {

                        }

                    }
                    GameController.currentMap = PlayerMap.castle1;
                    signAudio.Play();
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


    IEnumerator removeLoadingPanelToLibrary()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        GameController.enterLibrary = true;
    }

    IEnumerator removeLoadingPanelToCastle()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        GameController.enterCastle = true;
    }
}

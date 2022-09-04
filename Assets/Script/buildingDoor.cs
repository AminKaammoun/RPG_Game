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
                StartCoroutine(removeLoadingPanel());
                player.transform.position = new Vector3(-43.65f, -32.94f, 0f);
                GameController.currentMap = PlayerMap.Library;
                signAudio.Play();
            }
            {

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


    IEnumerator removeLoadingPanel()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        GameController.enterLibrary = true;
    }
}

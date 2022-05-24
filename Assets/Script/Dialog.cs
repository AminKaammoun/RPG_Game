using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public GameObject dialogBox;
    public bool playerInRange;
    public Text text;
    public string dialog;
    public GameObject key;
    public bool keyPressed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && keyPressed == false)
        {

            key.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                text.text = dialog;
                dialogBox.SetActive(true);
                keyPressed = true;
                key.SetActive(false);
            }
            {

            }
        }
        else if(playerInRange && keyPressed == true)
        {
            key.SetActive(false);
            dialogBox.SetActive(true);

        }
        else
        {
            key.SetActive(false);
            dialogBox.SetActive(false);
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
}

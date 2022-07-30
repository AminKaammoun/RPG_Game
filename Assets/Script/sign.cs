using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sign : MonoBehaviour
{

   
    public bool playerInRange; 
    public GameObject key;
    public bool keyPressed;
    public GameObject panel;

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
                panel.SetActive(true);
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

}

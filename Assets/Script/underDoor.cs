using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underDoor : MonoBehaviour
{


    private GameObject player;
    public bool playerInRange;
    public GameObject key;  
    public bool keyPressed;

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

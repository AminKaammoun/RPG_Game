using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public bool playerInRange;
    public static bool goldKeyObtained;

    public GameObject key;
    public GameObject player;
    public GameObject goldKeyCanvas;

    public AudioSource doorAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!goldKeyObtained)
        {
            goldKeyCanvas.SetActive(false);
        }
       
        if (playerInRange && goldKeyObtained)
        {
            key.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                doorAudio.Play();
                goldKeyObtained = false;

            }
        }
        else
        {
            key.SetActive(false);
        }
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist <= 1)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }

    }
}

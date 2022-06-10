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

    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && goldKeyObtained)
        {
            key.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                goldKeyCanvas.SetActive(false);
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

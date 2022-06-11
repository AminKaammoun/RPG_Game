using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    public bool playerInRange;
    public static bool silverKeyObtained;
   
    public GameObject key;
    public GameObject player;
    public GameObject silverKeyCanvas;

    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && silverKeyObtained)
        {
            key.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                silverKeyCanvas.SetActive(false);
                
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

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class hole : MonoBehaviour
{
  
    public GameObject Ekey;
    private bool playerInRange = false;
    public GameObject normalSoil;
    public GameObject holeSoil;

    public bool isDigged = false;

    public AudioSource digSoundEffect;

    public GameObject seedsPanel;
    public static bool getCurrentHole = false;
    public Button seedButton;

    public GameObject Corn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if(playerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!isDigged)
                {
                    cornSeed();
                    //seedsPanel.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!isDigged)
            {
                Ekey.SetActive(true);
                playerInRange = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!isDigged)
            {
                Ekey.SetActive(false);
                playerInRange = false;
  
            }
        }
    }

    public void cornSeed()
    {
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.262f, 0);
        Instantiate(Corn,transform.position -vec, Quaternion.identity); 
    }
}

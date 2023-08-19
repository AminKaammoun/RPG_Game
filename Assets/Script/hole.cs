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
    public GameObject Strawberry;
    public GameObject Eggplant;
    public GameObject Carrot;
    public GameObject Tomato;
    public GameObject Pepper;
    public GameObject Grape;

    public GameObject Potato;
    public GameObject GreenGrape;
    public GameObject Turnip;
    public GameObject Brockley;
    public GameObject Cabbage;
    public GameObject BlueBerry;
    public GameObject Cherry;
    
    public GameObject Kiwi;
    public GameObject OrangePepper;
    public GameObject YellowPepper;
    public GameObject Pineapple;
    public GameObject Pumpkin;
    public GameObject Melon;
    public GameObject WaterMelon;

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
                    //cornSeed();
                 
                    seedsPanel.SetActive(true);
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
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Corn,transform.position -vec, Quaternion.identity);
        GameController.resetCursor = true;
     
    }

    public void strawberrySeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Strawberry, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void carrotSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Carrot, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void eggplantySeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Eggplant, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }
    public void tomatoSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Tomato, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }
    public void pepperSeed()
    {

        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Pepper, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }
    public void grapeSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Grape, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void potatoSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Potato, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void greenGrapeSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(GreenGrape, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void turnipSeed()
    {
        PlayerMovements.isDigging = true;

        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Turnip, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void brockleySeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Brockley, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }
    public void cabbageSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Cabbage, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void blueberrySeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(BlueBerry, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void cherrySeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Cherry, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void kiwiSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Kiwi, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void orangePepperSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(OrangePepper, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void yellowPepperSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(YellowPepper, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void pineAppleSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Pineapple, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void pumpkinSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Pumpkin, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void melonSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(Melon, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

    public void waterMelonSeed()
    {
        PlayerMovements.isDigging = true;
        normalSoil.SetActive(false);
        holeSoil.SetActive(true);
        Ekey.SetActive(false);
        digSoundEffect.Play();
        isDigged = true;
        seedsPanel.SetActive(false);
        Vector3 vec = new Vector3(17.2166f, -175.15f, 0);
        Instantiate(WaterMelon, transform.position - vec, Quaternion.identity);
        GameController.resetCursor = true;
    }

}

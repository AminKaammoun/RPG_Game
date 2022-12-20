using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleportFromLibToVillage : MonoBehaviour
{

    private GameObject player;
    public GameObject tpPanel;
    public Text loading;
    private GameObject pet;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tpPanel.SetActive(true);
            StartCoroutine(removeLoadingPanel());
            player.transform.position = new Vector3(-37.66f, 2.44f, 0f);
            try
            {
                pet = GameObject.FindGameObjectWithTag("pet");
                pet.transform.position = new Vector3(-37.66f, 2.44f, 0f);
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
                    pet.transform.position = new Vector3(-37.66f, 2.44f, 0f);
                }
                catch (System.NullReferenceException)
                {

                }

            }
            GameController.currentMap = PlayerMap.Village;
        }
    }

    IEnumerator removeLoadingPanel()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        GameController.quitLibrary = true;
    }
}

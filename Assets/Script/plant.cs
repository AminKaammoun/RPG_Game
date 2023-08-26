using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{
    private GameObject player;
    public GameObject Ekey;
    public GameObject Plant;
    private bool isDone = false;
    public static bool playerInRockRange = false;
 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
       

     
        if (Vector3.Distance(this.gameObject.transform.position , player.transform.position) < 1 )
        {
            isDone = true;
            playerInRockRange = true;
            Ekey.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerMovements.animator.SetBool("harvesting", true);
                
            }
        }
        else
        {
            playerInRockRange = false;
            Ekey.SetActive(false);
           
        }

        if (!playerInRockRange)
        {
            if (isDone)
            {
                PlayerMovements.animator.SetBool("harvesting", false);
                isDone = false;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hoe"))
        {
            Instantiate(Plant,transform.position, Quaternion.identity);
            Destroy(gameObject);
          
            PlayerMovements.animator.SetBool("harvesting", false);
            GameController.playHarvestSound = true;
          
            int rand3 = Random.Range(0, 2);
            switch (rand3)
            {
                case 0:
                    GameController.harvestingLevel.AddExp(1);
                    break;
                case 1:
                    GameController.harvestingLevel.AddExp(2);
                    break;
            }

        }
    }

    IEnumerator backFromHarvesting()
    {
        yield return new WaitForSeconds(1f);
      
    }
 
}

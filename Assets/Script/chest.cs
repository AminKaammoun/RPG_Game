using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    private GameObject player;
    public GameObject E;
    public GameObject xpBall;
    public GameObject coin;


    public bool playerInRange;
    public static bool playChestAudio;
    // Start is called before the first frame update
    void Start()
    {
        
        playerInRange = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            E.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                playChestAudio = true;
                int rand1 = Random.Range(1, 5);
                int rand2 = Random.Range(1, 5);
                for(int i = 0; i< rand1; i++)
                {
                    Instantiate(xpBall, transform.position, Quaternion.identity);
                }
                for (int j = 0; j < rand2; j++)
                {
                    Instantiate(coin, transform.position, Quaternion.identity);
                }
                Destroy(this.gameObject);
            }
        }
        else
        {
            E.SetActive(false);
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

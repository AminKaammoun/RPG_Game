using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    private GameObject player;
    public GameObject Ekey;
    public GameObject wood;
    public GameObject leaf;
    public GameObject[] leafSpawner; 

    public Animator animator;

    public static bool playerInRockRange = false;
    private bool isDone = false;
    private float health = 6f;

    public GameObject smokeHit;
    public AudioClip[] treeMineSounds;
    public AudioSource mineSound;
    public AudioSource treeFallSound;

    private bool falling = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (falling)
            {
                falling = false;
                int rand = Random.Range(0, 2);
                switch (rand)
                {
                    case 0:
                        animator.SetBool("fall", true);
                        break;
                    case 1:
                        animator.SetBool("fall1", true);
                        break;
                }
            }
        }

        Vector3 add = new Vector3(0f, -1f, 0f);
        if (Vector3.Distance(this.gameObject.transform.position + add, player.transform.position) < 1 && health > 0)
        {
            isDone = true;
            playerInRockRange = true;
            Ekey.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerMovements.animator.SetBool("mineTree", true);
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
                PlayerMovements.animator.SetBool("mineTree", false);
                isDone = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickAxe"))
        {
            int rand1 = Random.Range(0, 3);
            switch (rand1)
            {
                case 0:
                    Instantiate(wood, transform.position, Quaternion.identity);
                    break;

            }
            foreach (GameObject spawner in leafSpawner)
            {
                int rand2 = Random.Range(0, 5);
                switch (rand2)
                {
                    case 0:
                        Instantiate(leaf, spawner.transform.position, Quaternion.identity);
                        break;
                }
            }
        
            health -= 1;
            if (health <= 0)
            {
                treeFallSound.Play();
                falling = true;
                //Destroy(this.gameObject, 5f);
            }
            animator.SetBool("shake", true);
            StartCoroutine(backFromTreeShake());
            Vector3 add = new Vector3(0f, -0.5f, 0f);
            var SmokeHit = Instantiate(smokeHit, transform.position + add, Quaternion.identity);
            Destroy(SmokeHit, 0.5f);

            int rand = Random.Range(0, 3);
            switch (rand)
            {
                case 0:
                    mineSound.clip = treeMineSounds[0];
                    mineSound.Play();
                    break;
                case 1:
                    mineSound.clip = treeMineSounds[1];
                    mineSound.Play();
                    break;
                case 2:
                    mineSound.clip = treeMineSounds[2];
                    mineSound.Play();
                    break;

            }
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
    IEnumerator backFromTreeShake()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("shake", false);
    }

}

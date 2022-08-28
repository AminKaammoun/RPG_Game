using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockRed : MonoBehaviour
{
    public AudioSource mineSound;
    public AudioSource stoneBreakSound;
    public AudioClip[] stoneMiningSound;

    public SpriteRenderer Rock;
    public Sprite[] rocks;
    private float health;

    public GameObject smoke;
    public GameObject smokeHit;

    private GameObject player;
    public GameObject Ekey;
    public GameObject redStone;


    public static bool playerInRockRange = false;
    private bool isDone = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                Rock.sprite = rocks[0];
                health = 9;
                break;
            case 1:
                Rock.sprite = rocks[1];
                health = 6;
                break;
            case 2:
                Rock.sprite = rocks[2];
                health = 3;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 6)
        {
            Rock.sprite = rocks[0];
        }
        else if (health <= 6 && health > 3)
        {
            Rock.sprite = rocks[1];
        }
        else if (health <= 3 && health > 0)
        {
            Rock.sprite = rocks[2];
        }
        else
        {
            Rock.sprite = rocks[3];

            playerInRockRange = false;
            Ekey.SetActive(false);
            transform.position = new Vector3(0f, 0f, 0f);
            Destroy(this.gameObject, 0.5f);
        }
        if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 1)
        {
            isDone = true;
            playerInRockRange = true;
            Ekey.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerMovements.animator.SetBool("mining", true);
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
                PlayerMovements.animator.SetBool("mining", false);
                isDone = false;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickAxe"))
        {
            int rand1 = Random.Range(0, 2);
            switch (rand1)
            {
                case 0:
                    Instantiate(redStone, transform.position, Quaternion.identity);
                    break;

            }

            Vector3 add = new Vector3(0f, 0.5f, 0f);
            var SmokeHit = Instantiate(smokeHit, transform.position + add, Quaternion.identity);
            Destroy(SmokeHit, 0.5f);
            health -= 1;
            if (health == 6 || health == 3 || health == 0)
            {
                stoneBreakSound.Play();
                var Smoke = Instantiate(smoke, transform.position, Quaternion.identity);
                Destroy(Smoke, 0.5f);
            }
            int rand = Random.Range(0, 8);
            switch (rand)
            {
                case 0:
                    mineSound.clip = stoneMiningSound[0];
                    mineSound.Play();
                    break;
                case 1:
                    mineSound.clip = stoneMiningSound[1];
                    mineSound.Play();
                    break;
                case 2:
                    mineSound.clip = stoneMiningSound[2];
                    mineSound.Play();
                    break;
                case 3:
                    mineSound.clip = stoneMiningSound[3];
                    mineSound.Play();
                    break;
                case 4:
                    mineSound.clip = stoneMiningSound[4];
                    mineSound.Play();
                    break;
                case 5:
                    mineSound.clip = stoneMiningSound[5];
                    mineSound.Play();
                    break;
                case 6:
                    mineSound.clip = stoneMiningSound[6];
                    mineSound.Play();
                    break;
                case 7:
                    mineSound.clip = stoneMiningSound[7];
                    mineSound.Play();
                    break;

            }
        }
    }
}

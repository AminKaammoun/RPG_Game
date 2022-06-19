using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WormState
{

    walk,
    attack,
    stagger,
    dead,
    stun,
    rage,
    rage2
}
public class Worm : MonoBehaviour
{
    public Vector3 target;
    public float speed = 1.5f;

    public SpriteRenderer worm;
    private float TimeBtwAttack;
    public float startTime = 1f;
    public Animator anim;

    public GameObject fireBall;
    public GameObject RageFireBall;
    public GameObject wormEnemy;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject chest;
    public GameObject board;

    public HealthBar healthbar;

    public int counter = 0;
    public float health = 100f;
    public WormState currentState;

    public bool chestIsInstantiated;
    public static bool isdead = false;

    // Start is called before the first frame update
    void Start()
    {
        board.SetActive(true);
        currentState = WormState.walk;
        target = new Vector3(112.9f, 75.77f, 0f);
        TimeBtwAttack = startTime;
        chestIsInstantiated = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 50 && currentState == WormState.walk)
        {
            currentState = WormState.rage;
        }
        if (health <= 25 && currentState == WormState.rage)
        {
            currentState = WormState.rage2;
        }
        healthbar.SetHealth(health);
        if (health <= 0)
        {
            isdead = true;
            anim.SetBool("die", true);
            currentState = WormState.dead;
            CameraMovement.bigShake = true;
            Time.timeScale = 0.5f;
            Destroy(this.gameObject, 1.5f);
            Instantiate(chest, transform.position, Quaternion.identity);
            TeleportToDunLvl4.isclosed = false;
            StartCoroutine(backFromSlowMo());
            health = 1;

        }
        if (counter >= 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(106.3624f, 69.12473f, 0f), 10 * Time.deltaTime);
            anim.SetBool("stun", true);

            currentState = WormState.stun;
            StartCoroutine(backFromStun());

        }

        if (currentState == WormState.walk)
        {
            speed = 1.5f;
            if (TimeBtwAttack <= 0)
            {
                anim.SetBool("attack", true);
                if (worm.flipX)
                {
                    StartCoroutine(waitBeforeShooting(spawn2));
                    counter++;
                }
                else
                {
                    StartCoroutine(waitBeforeShooting(spawn1));
                    counter++;
                }
                TimeBtwAttack = Random.Range(1, 5);
                StartCoroutine(backToWalk());
            }
            else
            {
                TimeBtwAttack -= Time.deltaTime;
            }

            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position.x == 101.15f)
            {
                worm.flipX = false;
                target = new Vector3(112.9f, 75.77f, 0f);
            }
            else if (transform.position.x == 112.9f)
            {
                worm.flipX = true;
                target = new Vector3(101.15f, 75.77f, 0f);
            }

        }
        if (currentState == WormState.rage)
        {
            speed = 4f;
            if (TimeBtwAttack <= 0)
            {
                anim.SetBool("attack", true);
                if (worm.flipX)
                {
                    StartCoroutine(waitBeforeShooting(spawn2));
                    counter++;
                }
                else
                {
                    StartCoroutine(waitBeforeShooting(spawn1));
                    counter++;
                }
                TimeBtwAttack = Random.Range(1, 3);
                StartCoroutine(backToWalk());
            }
            else
            {
                TimeBtwAttack -= Time.deltaTime;
            }

            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position.x == 101.15f)
            {
                worm.flipX = false;
                target = new Vector3(112.9f, 75.77f, 0f);
            }
            else if (transform.position.x == 112.9f)
            {
                worm.flipX = true;
                target = new Vector3(101.15f, 75.77f, 0f);
            }

        }
        if (currentState == WormState.rage2)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(106.35f, 73.2f, 0f), speed * Time.deltaTime);
            if (TimeBtwAttack <= 0)
            {
                anim.SetBool("attack", true);
                int r = Random.Range(0, 2);
                switch (r)
                {
                    case 0:
                        worm.flipX = false;
                        anim.SetBool("attack", true);
                        StartCoroutine(waitBeforeShootingRage(spawn1));
                        counter++;
                        break;
                    case 1:
                        worm.flipX = true;
                        anim.SetBool("attack", true);
                        StartCoroutine(waitBeforeShootingRage(spawn2));
                        counter++;
                        break;
                }
             
                TimeBtwAttack = Random.Range(1, 3);
                StartCoroutine(backToWalk());
            }
            else
            {
                TimeBtwAttack -= Time.deltaTime;
            }
            
        }
       
    }

    IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
    }
    IEnumerator backToWalk()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("attack", false);
    }
    IEnumerator waitBeforeShooting(GameObject spawn)
    {
        yield return new WaitForSeconds(1f);
        Instantiate(fireBall, spawn.transform.position, Quaternion.identity);
    }
    IEnumerator waitBeforeShootingRage(GameObject spawn)
    {
        yield return new WaitForSeconds(1f);
        Instantiate(RageFireBall, spawn.transform.position, Quaternion.identity);
    }
    IEnumerator backFromStun()
    {
        yield return new WaitForSeconds(5f);
        anim.SetBool("stun", false);
        counter = 0;
        if (currentState != WormState.dead)
        {
            currentState = WormState.walk;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(106.3624f, 75.54301f, 0f), 10 * Time.deltaTime);
        }
    }
    IEnumerator backFromStagger()
    {
        yield return new WaitForSeconds(0.18f);
        anim.SetBool("stagger", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hitBox") && currentState == WormState.stun)
        {
            CameraMovement.shake = true;
            health -= 5f;
            StartCoroutine(backFromStagger());
            currentState = WormState.stagger;
            anim.SetBool("stagger", true);
        }
    }
}

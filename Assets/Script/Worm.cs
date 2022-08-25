using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    private Transform player;

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
    public GameObject slashEff;
    public GameObject damage;
    public GameObject Blood;

    public AudioSource hurtAudio;
    public AudioSource rageAudio;
    public AudioSource rage1Audio;
    public AudioSource slideAudio;
    public AudioSource dieAudio;
    public AudioSource audioSource;

    public AudioClip dunSound;

    public HealthBar healthbar;

    public Text healthText;

    public int counter = 0;
    private float health = 200f;
    public WormState currentState;

    public bool chestIsInstantiated;
    public static bool isdead = false;
    private bool playRageAudio = true;
    private bool playRage1Audio = true;
    private bool playSlideAudio = true;
    private bool playDieAudio = true;

    public bool isHurt;
    public static float defence = 2000;
    public static float attack = 80;
    public bool canBeDamaged = true;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player").transform;
        board.SetActive(true);
        currentState = WormState.walk;
        target = new Vector3(96.04f, 83.68695f, 0f);
        TimeBtwAttack = startTime;
        chestIsInstantiated = true;

    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = health.ToString() + " / 200";
        if (isHurt)
        {
            hurtAudio.Play();
            GameObject slashEffect = Instantiate(slashEff) as GameObject;
            SpriteRenderer rend = slashEffect.GetComponent<SpriteRenderer>();
            if (player.position.x > transform.position.x)
            {
                rend.flipX = true;
            }
            slashEffect.transform.parent = this.gameObject.transform;
            slashEffect.transform.position = transform.position;
            isHurt = false;
            Destroy(slashEffect, 0.5f);
        }

        if (health <= 100 && currentState == WormState.walk)
        {
            currentState = WormState.rage;
        }
        if (health <= 50 && currentState == WormState.rage)
        {
            currentState = WormState.rage2;
        }
        healthbar.SetHealth(health);
        if (health <= 0)
        {
            if (playDieAudio)
            {
                dieAudio.Play();
                GameController.returnDunMusic = true;
                playDieAudio = false;
            }
            Instantiate(Blood, transform.position, Quaternion.identity);

            isdead = true;
            anim.SetBool("die", true);
            currentState = WormState.dead;
            CameraMovement.bigShake = true;
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            GameController.enemyBeaten = true;
            FindObjectOfType<RippleEffect>().Emit(Camera.main.WorldToViewportPoint(transform.position));
            Destroy(this.gameObject, 1.5f);
            Instantiate(chest, transform.position, Quaternion.identity);
            ForrestDungeon1.isclosed = false;
            StartCoroutine(backFromSlowMo());
            health = 1;

        }
        if (counter >= 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(89.92f, 77.02f, 0f), 10 * Time.deltaTime);
            anim.SetBool("stun", true);

            currentState = WormState.stun;
            StartCoroutine(backFromStun());


        }
        if (currentState == WormState.stun)
        {
            if (playSlideAudio)
            {
                slideAudio.Play();
                playSlideAudio = false;
            }
        }
        if (currentState == WormState.walk)
        {
            playSlideAudio = true;
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
            if (transform.position.x == 83.83f)
            {
                worm.flipX = false;
                target = new Vector3(96.04f, 83.68695f, 0f);
            }
            else if (transform.position.x == 96.04f)
            {
                worm.flipX = true;
                target = new Vector3(83.83f, 83.68695f, 0f);
            }

        }
        if (currentState == WormState.rage)
        {
            speed = 4f;
            if (playRageAudio)
            {
                rageAudio.Play();
                playRageAudio = false;
            }

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
            if (transform.position.x == 83.83f)
            {
                worm.flipX = false;
                target = new Vector3(96.04f, 83.68695f, 0f);
            }
            else if (transform.position.x == 96.04f)
            {
                worm.flipX = true;
                target = new Vector3(83.83f, 83.68695f, 0f);
            }

        }
        if (currentState == WormState.rage2)
        {
            if (playRage1Audio)
            {
                rage1Audio.Play();
                playRage1Audio = false;
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(89.61f, 80.85f, 0f), speed * Time.deltaTime);

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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(89.12503f, 83.63966f, 0), 10 * Time.deltaTime);
        }
    }
    IEnumerator backFromStagger()
    {
        yield return new WaitForSeconds(0.18f);
        anim.SetBool("stagger", false);
        canBeDamaged = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("hitBox") || collision.gameObject.CompareTag("ultSlash")) && currentState == WormState.stun)
        {
            if (canBeDamaged)
            {
                canBeDamaged = false;
                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(damage, transform.position + add, Quaternion.identity);
                isHurt = true;
                CameraMovement.shake = true;
                if (collision.CompareTag("hitBox"))
                {
                    damageText.num = 1;
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damages = attack * (100 / (100 + defence));
                    health -= (int)damages;
                }
                else if (collision.gameObject.CompareTag("ultSlash"))
                {
                    damageText.num = 3;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damages = attack * (100 / (100 + defence));
                    health -= (int)damages;
                }
                StartCoroutine(backFromStagger());
                currentState = WormState.stagger;
                anim.SetBool("stagger", true);

            }
        }
    }
}

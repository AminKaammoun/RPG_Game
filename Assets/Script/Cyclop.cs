using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CyclopState
{

    walk,
    attack,
    stagger,
    dead,
    stun,
    rage,
    rage2
}
public class Cyclop : MonoBehaviour
{
    private CyclopState currentState;
    private float speed = 3f;
    public Animator anim;
    private Vector3 target;
    private Transform player;

    private float TimeBtwShoot;
    private float StartTime;
    private float health = 100f;
    private int numberOfProjectiles = 0;
    private bool isHurt = false;

    public GameObject Projectile;
    public GameObject slashEff;
    public GameObject chest;
    public GameObject blood;

    public AudioSource hurtAudio;
    public AudioSource dieAudio;
    public AudioSource rageAudio;

    public HealthBar healthbar;

    private bool playRageAudio = true;
    private bool playDieAudio = true;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player").transform;
        currentState = CyclopState.walk;
        target = new Vector3(160.22f, 85.26f, 0f);
        float rand = Random.Range(0, 3);
        StartTime = rand;
        TimeBtwShoot = StartTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (playDieAudio)
            {
                dieAudio.Play();
                GameController.returnDunMusic = true;
                playDieAudio = false;
            }
            //isdead = true;
            
            statue.isRaged = false;
           
            anim.SetBool("dead", true);
            currentState = CyclopState.dead;
            CameraMovement.bigShake = true;
            Time.timeScale = 0.5f;
            FindObjectOfType<RippleEffect>().Emit(Camera.main.WorldToViewportPoint(transform.position));
            Destroy(this.gameObject, 2f);
            Instantiate(chest, transform.position, Quaternion.identity);
            ForrestDungeon1.isclosed = false;
            StartCoroutine(backFromSlowMo());
            ForrestDungeon2.inFight = false;
            ForrestDungeon2.cyclopIsBeaten = true;
            health = 1;

        }
        if (health <= 50 && currentState == CyclopState.walk && health > 1)
        {
            currentState = CyclopState.rage;
        }

        healthbar.SetHealth(health);
        if (isHurt)
        {
            hurtAudio.Play();
            var bloods = Instantiate(blood, transform.position, Quaternion.identity);
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
            Destroy(bloods, 3f);
        }

        if (numberOfProjectiles >= 10)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 79f, 0f), 5 * Time.deltaTime);
            currentState = CyclopState.stun;
            if (transform.position.y == 79f)
            {
                anim.SetBool("walk", false);
            }

        }

        if (currentState == CyclopState.walk)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            anim.SetBool("walk", true);
            if (transform.position.x == 160.22f)
            {
                target = new Vector3(147.15f, 85.26f, 0f);
            }
            else if (transform.position.x == 147.15f)
            {
                target = new Vector3(160.22f, 85.26f, 0f);
            }

            if (TimeBtwShoot <= 0)
            {
                Instantiate(Projectile, transform.position, Quaternion.identity);
                numberOfProjectiles++;
                StartTime = Random.Range(0, 3);
                TimeBtwShoot = StartTime;
            }
            else
            {
                TimeBtwShoot -= Time.deltaTime;
            }
        }
        else if (currentState == CyclopState.stun)
        {
            StartCoroutine(backToWalk());
        }
        else if (currentState == CyclopState.rage && health > 1)
        {
            statue.isRaged = true;
            if (playRageAudio)
            {
                rageAudio.Play();
                playRageAudio = false;
            }

            transform.position = Vector3.MoveTowards(transform.position, target, speed * 1.25f * Time.deltaTime);
            anim.SetBool("walk", true);
            if (transform.position.x == 160.22f)
            {
                target = new Vector3(147.15f, 85.26f, 0f);
            }
            else if (transform.position.x == 147.15f)
            {
                target = new Vector3(160.22f, 85.26f, 0f);
            }

            if (TimeBtwShoot <= 0)
            {
                Instantiate(Projectile, transform.position, Quaternion.identity);
                numberOfProjectiles++;
                StartTime = Random.Range(0, 2);
                TimeBtwShoot = StartTime;
            }
            else
            {
                TimeBtwShoot -= Time.deltaTime;
            }
        }
        else if (currentState == CyclopState.dead)
        {
            statue.isRaged = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hitBox") && currentState == CyclopState.stun)
        {
            isHurt = true;
            CameraMovement.shake = true;
            health -= 5f;
            StartCoroutine(backFromStagger());
            currentState = CyclopState.stagger;
            anim.SetBool("hurt", true);
        }
    }
    IEnumerator backFromStagger()
    {
        yield return new WaitForSeconds(0.3f);
        currentState = CyclopState.stun;
        anim.SetBool("hurt", false);
    }
    IEnumerator backToWalk()
    {
        yield return new WaitForSeconds(5f);
        numberOfProjectiles = 0;
        currentState = CyclopState.walk;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(153.02f, 85.26f, 0f), 5 * Time.deltaTime);
    }
    IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
    }
}

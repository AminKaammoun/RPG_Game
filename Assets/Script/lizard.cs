using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum LizardState
{

    walk,
    attack,
    stagger,
    dead,
    stun,
    rage,
    rage2
}

public class lizard : MonoBehaviour
{
    private LizardState currentState;
    private float speed = 3f;

    private Animator anim;
    private SpriteRenderer Lizard;
    private float TimeBtwBatSpawn;

    private Vector3 target;

    public GameObject bat;
    public GameObject Shield;
    public GameObject damage;
    public GameObject slashEff;
    public GameObject Blood;
    
    private bool canBeDamaged = false;
    private bool firstBatSpawned = false;
    private bool isHurt;

    private int batCounter = 0;
    private int batsToSpawn = 3;
    private float health = 200f;
    public static float defence = 6000;
   
    public AudioSource bowHitAudio;
    public AudioSource hurtAudio;
    public AudioSource deathAudio;
    public AudioSource rageAudio;
   
    public HealthBar healthBar;
    public Text healthText;
   
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        currentState = LizardState.walk;
        target = new Vector3(92.54f, 245.32f, 0f);
        Lizard = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
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
        healthText.text = health.ToString() + " / 200";
        healthBar.SetHealth(health);
       
        if (batCounter == batsToSpawn && firstBatSpawned == true)
        {
            canBeDamaged = true;
            int rand = Random.Range(0, 2);
            rageAudio.Play();
            switch (rand)
            {
                case 0:
                    currentState = LizardState.rage;
                    anim.SetBool("rage1", true);
                    StartCoroutine(backFromRage());
                    break;
                case 1:
                    currentState = LizardState.rage2;
                    anim.SetBool("rage2", true);
                    StartCoroutine(backFromRage());
                    break;

            }
            currentState = LizardState.rage;
            firstBatSpawned = false;
            StartCoroutine(resetBats());
        }
        
        if (TimeBtwBatSpawn <= 0)
        {
            if (batCounter < batsToSpawn)
            {
                int rand = Random.Range(0, 4);
                switch (rand)
                {
                    case 0:
                        Instantiate(bat, new Vector3(76.54f, 241.26f, 0f), Quaternion.identity);
                        firstBatSpawned = true;
                        batCounter++;
                        break;
                    case 1:
                        Instantiate(bat, new Vector3(76.54f, 236.21f, 0f), Quaternion.identity);
                        firstBatSpawned = true;
                        batCounter++;
                        break;
                    case 2:
                        Instantiate(bat, new Vector3(94.51f, 236.21f, 0f), Quaternion.identity);
                        firstBatSpawned = true;
                        batCounter++;
                        break;
                    case 3:
                        Instantiate(bat, new Vector3(94.51f, 241.16f, 0f), Quaternion.identity);
                        firstBatSpawned = true;
                        batCounter++;
                        break;
                }
               
            }
            int rand1 = Random.Range(1, 4);
            TimeBtwBatSpawn = rand1;
        }
        else
        {
            TimeBtwBatSpawn -= Time.deltaTime;
        }

        if (currentState == LizardState.walk)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if (transform.position.x == 92.54f)
            {
                target = new Vector3(78.53f, 245.32f, 0f);
                Lizard.flipX = true;
            }
            else if (transform.position.x == 78.53f)
            {
                target = new Vector3(92.54f, 245.32f, 0f);
                Lizard.flipX = false;
            }

        }
        if(currentState == LizardState.stun)
        {
            anim.SetBool("stun", true);
            StartCoroutine(returnToWalk());
        }
        if(health <= 0)
        {
            health = 1;
            currentState = LizardState.dead;
            deathAudio.Play();
            anim.SetBool("death", true);
            Instantiate(Blood, transform.position, Quaternion.identity);
            CameraMovement.bigShake = true;
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            GameController.enemyBeaten = true;
            FindObjectOfType<RippleEffect>().Emit(Camera.main.WorldToViewportPoint(transform.position));
            Destroy(this.gameObject, 1.5f);
            StartCoroutine(backFromSlowMo());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow")||collision.CompareTag("hitBox") )
        {
            if (canBeDamaged)
            {
                if (collision.CompareTag("hitBox"))
                {
                    isHurt = true;
                    defence = 4000;
                    damageText.num = 5;
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damages = attack * (100 / (100 + defence));
                    health -= (int)damages;
                }
                if (collision.CompareTag("Arrow"))
                {
                    defence = 7000;
                    bowHitAudio.Play();
                    damageText.num = 5;
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damages = attack * (100 / (100 + defence));
                    health -= (int)damages;
                }

                    anim.SetBool("hurt", true);
                    Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                    Instantiate(damage, transform.position + add, Quaternion.identity);
                    CameraMovement.shake = true;
                    StartCoroutine(returnFromHurt());
            }
            else
            {
                var shield = Instantiate(Shield, transform.position, Quaternion.identity);
                Destroy(shield, 0.5f);
            }
            
        }
        
    }
    IEnumerator returnFromHurt()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("hurt", false);
    }

   IEnumerator resetBats()
    {
        yield return new WaitForSeconds(7f);
        batsToSpawn += 1;
        batCounter = 0;
        canBeDamaged = false;
    }

    IEnumerator backFromRage()
    {
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("rage1", false);
        anim.SetBool("rage2", false);
        currentState = LizardState.stun;
    }
    IEnumerator returnToWalk()
    {
        yield return new WaitForSeconds(5.5f);
        currentState = LizardState.walk;
        anim.SetBool("stun", false);
    }
    IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;

    }
}

using System.Collections;
using UnityEngine;
using DG.Tweening;
using TMPro;
using Unity.Properties;

using UnityEngine.UI;

public class Cacodaemon : MonoBehaviour
{
    private float moveSpeed = 3f;
    private float desiredDistance = 7f;
    private Transform player;
    private bool faceLeft = true;
    public static float attack;

    private bool isRoaming = true;
    private bool isDashing = false;
    private bool isAttacking = false;
    private bool isRaging = false;

    private float timeBtwDash = 5f;
    private Vector3 lastKnownPlayerPosition;

    private int dashCounter = 0;
    private Animator animator;
    public GameObject projectile;
    private int projectileCounter = 0;

    private float timeBtwShoot = 1f;
    private float TimeBtwGettingPosition = 0f;

    public GameObject right;
    public GameObject left;
    public GameObject projectileStatic;

    public GameObject ghost;
   
    private SpriteRenderer spriteRenderer;
    private float timeBtwGhost = 0f;

    public AudioSource dash;
    private bool dashAudioPlayed = false;
    public AudioSource attackAudio;
    public AudioSource dropSound;
    public AudioSource energySound;
    public AudioSource dieSound;
    public ParticleSystem particle;
    public ParticleSystem particle1;

    public GameObject smoke;
    private bool wasRaging = true;
    private bool hasPlayedEnergySound = false;
    private float health = 10;
    public static float defence = 6000;

    public GameObject boxCollider;
    public GameObject damage;
    public GameObject chest;

    public bool isHurt;
    private bool canBeDamaged = true;
    public AudioSource hurtAudio;
    public GameObject slashEff;

    public HealthBar healthBar;
    public Text healthText;
    private bool isDead = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
       particle.Stop();
    }


    private void Update()
    {

        healthText.text = health.ToString() + " / 400";
        healthBar.SetHealth(health);

        if (isHurt)
        {

            hurtAudio.Play();
            animator.SetBool("hurt", true);
            StartCoroutine(backFromAnim());

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
        if (!isDead)
        {
            if (health <= 0)

            {
                dieSound.Play();
                animator.SetBool("dead", true);
                CameraMovement.bigShake = true;
                Time.timeScale = 0.5f;
                Time.fixedDeltaTime = Time.timeScale * 0.02f;
                GameController.enemyBeaten = true;

                Destroy(this.gameObject, 1.5f);
                Instantiate(chest, transform.position, Quaternion.identity);

                StartCoroutine(backFromSlowMo());
                isDead = true;
            }



            checkDirection();

            if (faceLeft)
            {
                projectileStatic.transform.position = right.transform.position;
            }
            else
            {
                Vector3 add = new Vector3(2.25f, 0, 0);
                projectileStatic.transform.position = left.transform.position - add;
            }

            if (!isRaging)
            {
                if (timeBtwDash < 0)
                {

                    isDashing = true;
                    isRoaming = false;
                    lastKnownPlayerPosition = player.position;
                    timeBtwDash = 5f; // Reset the dash timer
                                      // Store the player's position when starting to dash
                }
                else
                {
                    timeBtwDash -= Time.deltaTime;
                }
            }
            else
            {
                if (TimeBtwGettingPosition < 0f)
                {
                    lastKnownPlayerPosition = player.position;
                    TimeBtwGettingPosition = 2f;
                }
                else
                {
                    TimeBtwGettingPosition -= Time.deltaTime;
                }
            }
            Vector3 directionToPlayer = player.position - transform.position;

            if (isRoaming)
            {
                boxCollider.SetActive(false);
                float distanceToPlayer = directionToPlayer.magnitude;
                particle1.Stop();
                if (distanceToPlayer > desiredDistance)
                {
                    // Move the boss towards the player
                    transform.position += directionToPlayer.normalized * moveSpeed * Time.deltaTime;
                }
                else if (distanceToPlayer < desiredDistance)
                {
                    // Move the boss away from the player
                    transform.position -= directionToPlayer.normalized * moveSpeed * Time.deltaTime;
                }
            }
            else if (isDashing)
            {

                boxCollider.SetActive(true);

                if (timeBtwGhost < 0)
                {
                    GameObject ghosting = Instantiate(ghost, transform.position, Quaternion.identity);
                    spriteRenderer = ghosting.GetComponent<SpriteRenderer>();
                    spriteRenderer.sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                    if (!faceLeft)
                    {
                        spriteRenderer.flipX = true;
                    }
                    timeBtwGhost = 0.1f;
                }
                else
                {
                    timeBtwGhost -= Time.deltaTime;
                }

                if (isDashing && !dashAudioPlayed)
                {
                    dash.Play();
                    dashAudioPlayed = true;
                }


                Vector3 directionToLastKnownPosition = lastKnownPlayerPosition - transform.position;
                Vector3 normalizedDirectionToLastKnownPosition = directionToLastKnownPosition.normalized;

                Vector3 finalPosition = lastKnownPlayerPosition + normalizedDirectionToLastKnownPosition * 5f;

                transform.DOMove(finalPosition, 2f);


                if (Vector3.Distance(transform.position, lastKnownPlayerPosition) < 0.1f)
                {
                    isDashing = false;
                    StartCoroutine(backToRoaming());
                    dashCounter++;
                    dashAudioPlayed = false;
                    StartCoroutine(desactivateBoxColldier());

                }
            }


            if (isAttacking)
            {
                boxCollider.SetActive(false);
                isDashing = false;
                isRoaming = false;
                animator.SetBool("attack", true);

                if (!attackAudio.isPlaying)
                {
                    attackAudio.Play();
                }

                if (timeBtwShoot < 0)
                {
                    Instantiate(projectile, transform.position, Quaternion.identity);
                    particle1.Play();
                    projectileCounter++;

                    if (projectileCounter > 2)
                    {
                        isAttacking = false;
                        animator.SetBool("attack", false);
                        projectileStatic.SetActive(false);
                        isRoaming = true;
                        projectileCounter = 0;
                    }
                    timeBtwShoot = 1.5f;
                }
                else
                {
                    timeBtwShoot -= Time.deltaTime;
                }

            }

            if (isRaging)
            {
                boxCollider.SetActive(true);
                Vector3 add = new Vector3(0, 6f, 0);
                transform.position = Vector3.MoveTowards(transform.position, lastKnownPlayerPosition + add, 15f * Time.deltaTime);
                GameController.cacodeamonUltEffect = true;
                GameController.attack3rd = true;
                if (!hasPlayedEnergySound)
                {
                    energySound.Play();
                    hasPlayedEnergySound = true;
                    particle.Play();
                }
                StartCoroutine(dashAtPlayer());


                wasRaging = true;
            }
            else if (wasRaging && !isRaging)

            {
                CameraMovement.bigbigShake = true;
                GameController.attack3rd = false;
                GameController.cacodeamonUltEffect = false;
                Vector3 add = new Vector3(2f, 0, 0);
                Instantiate(smoke, transform.position + add, Quaternion.identity);
                GameObject obg = Instantiate(smoke, transform.position - add, Quaternion.identity);

                SpriteRenderer spriteRenderer = obg.GetComponent<SpriteRenderer>();
                spriteRenderer.flipX = true;
                dropSound.Play();
                hasPlayedEnergySound = false;
                particle.Stop();
                wasRaging = false;

            }



        }
    }


    IEnumerator dashAtPlayer()
    {
        yield return new WaitForSeconds(1.5f);

        while (Vector3.Distance(transform.position, lastKnownPlayerPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, lastKnownPlayerPosition, 0.5f * Time.deltaTime);
            yield return null;
        }
    

        isRaging = false;
        isRoaming = true;
      

    }

    IEnumerator backToRoaming()
    {
        yield return new WaitForSeconds(2f);

        if (dashCounter >= 3)
        {
            

            int random = Random.Range(0, 2);
            switch (random)
            {
                case 0:
                     isRoaming = false;
                     isAttacking = true;

                     int rand = Random.Range(0, 4);
                     dashCounter = rand;
                     break;
                  
                case 1:
                    isRaging = true;
                    isRoaming = false;
                    isAttacking = false;
                    isDashing = false;
                    int rand2 = Random.Range(0, 4);
                    dashCounter = rand2;
                    break;

              
                 
            }

          
        }
        else
        {
            isRoaming = true;
            isAttacking = false;
        }
    }

    private void checkDirection()
    {
        if (player.position.x < transform.position.x && faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = false;

        }
        else if (player.position.x > transform.position.x && !faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = true;

        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow") || collision.gameObject.CompareTag("ultSlash") || collision.gameObject.CompareTag("rockUlt") || collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5") || collision.gameObject.CompareTag("windUlt") || collision.gameObject.CompareTag("thunderStrike"))
        {
            if (canBeDamaged)
            {

                if (collision.gameObject.CompareTag("hitBox"))
                {
                    defence = 6000;
                    damageText.num = 7;
                    
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    GameController.ultValue += 0.5f;
                    TakeDamage((int)damage);

                }

                else if (collision.gameObject.CompareTag("Arrow"))
                {
                    defence = 9000;
                    damageText.num = 7;
                    
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    GameController.ultValue += 0.5f;
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("ultSlash"))
                { 
                    defence = 6000;
                    damageText.num = -6;
                   

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill1Level / 100);
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("rockUlt"))
                {
                    defence = 6000;
                    damageText.num = -7;
                    
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill2Level / 100);
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5"))
                {
                    defence = 6000;
                    damageText.num = -8;
                    
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill3Level / 100) * 1.2f;
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("windUlt"))
                {
                    defence = 6000;
                    damageText.num = -9;
                    
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill4Level / 100) * 1.2f;
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("thunderStrike"))
                {
                    defence = 6000;
                    damageText.num = -10;
                    
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.5f;
                    damage = damage + damage * (GameController.skill5Level / 100) * 1.5f;
                    TakeDamage((int)damage);
                }
                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(damage, transform.position + add, Quaternion.identity);

                canBeDamaged = false;
                if (health <= 0)
                {
                    canBeDamaged = false;
                    isHurt = true;
                    //int rand = Random.Range(0, 2);
                    //Log.color = new Color(1f, 0f, 0f);
                    //StartCoroutine(waitAfterDead());


                    Destroy(gameObject, 5f);


                }
                else
                {

                    //Log.color = new Color(1f, 0f, 0f);
                    isHurt = true;
                    StartCoroutine(waitAfterHurt());


                }
            }
        }
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        //Log.color = new Color(1f, 1f, 1f);
        canBeDamaged = true;
    }

   IEnumerator desactivateBoxColldier()
    {
        yield return new WaitForSeconds(0.5f);
        
        boxCollider.SetActive(false);
        
    }

    IEnumerator backFromAnim()
    {
        yield return new WaitForSeconds(0.35f);
        animator.SetBool("hurt", false);
    }

    IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
    }
}
        
       

    

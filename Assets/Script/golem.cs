using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class golem : Enemy
{
    public Transform target;
    private float chaseRadius = 50f;
    private float attackRadius = 0.5f;
    //public Transform homePosition;
    public Rigidbody2D player;
    public GameObject blood;
    public SpriteRenderer slime;
    private bool faceLeft = true;
    public GameObject slashEff;
    public GameObject xp;
    public GameObject coin;
    public GameObject DamageText;
    public GameObject[] splash;
    public GameObject splashBlood;
    public GameObject deadLightFish;
    public GameObject projectile;
    public GameObject[] parts;
    public GameObject smoke;
    private float timeBtwAttack = 3f;

    public AudioSource hurtAudio;
    public AudioSource BowHurtAudio;
    public AudioSource gunHurtAudio;

    private bool isHurt = false;
    private bool canBeDamaged = true;

    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.FindWithTag("Player").transform;
        slime = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        checkDirection();
        if (isHurt && PlayerMovements.currentWeapon == PlayerWeapon.sword)
        {
            hurtAudio.Play();
            GameObject slashEffect = Instantiate(slashEff) as GameObject;
            SpriteRenderer rend = slashEffect.GetComponent<SpriteRenderer>();
            if (target.position.x > transform.position.x)
            {
                rend.flipX = true;
            }
            slashEffect.transform.parent = this.gameObject.transform;
            slashEffect.transform.position = transform.position;
            isHurt = false;
            Destroy(slashEffect, 0.5f);
        }
        else if (isHurt && PlayerMovements.currentWeapon == PlayerWeapon.bow)
        {
            BowHurtAudio.Play();
            isHurt = false;

        }else if (isHurt && PlayerMovements.currentWeapon == PlayerWeapon.rifle)
        {
            gunHurtAudio.Play();
            isHurt = false;
        }


        if(timeBtwAttack < 0)
        {
            animator.SetBool("attacking", true);
            currentState = EnemyState.attack;
            Instantiate(projectile, transform.position, Quaternion.identity);
            StartCoroutine(waitAfterattack());
            timeBtwAttack = 3f;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        } 

    }

    void checkDistance()
    {
        Vector3 directionToPlayer = target.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;
       
        if (distanceToPlayer > 10f)
        {
            // Move the boss towards the player
            transform.position += directionToPlayer.normalized * moveSpeed * Time.deltaTime;
        }
        else if (distanceToPlayer < 10f)
        {
            // Move the boss away from the player
            transform.position -= directionToPlayer.normalized * moveSpeed * Time.deltaTime;
        }
    }

    void checkDirection()
    {
        if (target.position.x < transform.position.x && faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = false;
        }
        else if (target.position.x > transform.position.x && !faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow") || collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("rockUlt") || collision.gameObject.CompareTag("ultSlash") || collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5") || collision.gameObject.CompareTag("windUlt") || collision.gameObject.CompareTag("thunderStrike"))
        {
            if (canBeDamaged)
            {
                if (collision.gameObject.CompareTag("hitBox"))
                {
                    defence = 1000;
                    damageText.num = 0;

                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    TakeDamage((int)damage);
                    GameController.ultValue += 0.5f;
                }
                else if (collision.gameObject.CompareTag("Arrow"))
                {
                    defence = 3000;
                    damageText.num = 0;

                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    TakeDamage((int)damage);
                    GameController.ultValue += 0.5f;
                }
                else if (collision.gameObject.CompareTag("bullet"))
                {
                    defence = 2000;
                    damageText.num = 0;

                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    TakeDamage((int)damage);
                    GameController.ultValue += 0.5f;
                }
                else if (collision.gameObject.CompareTag("ultSlash"))
                {
                    defence = 1000;
                    damageText.num = -1;

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill1Level / 100);
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("rockUlt"))
                {
                    defence = 1000;
                    damageText.num = -2;

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill2Level / 100);
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5"))
                {
                    defence = 1000;
                    damageText.num = -3;

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill3Level / 100) * 1.2f;
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("windUlt"))
                {
                    defence = 1000;
                    damageText.num = -4;

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill4Level / 100) * 1.2f;
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("thunderStrike"))
                {
                    defence = 1000;
                    damageText.num = -5;

                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.5f;
                    damage = damage + damage * (GameController.skill5Level / 100) * 1.5f;
                    TakeDamage((int)damage);
                }


                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(DamageText, transform.position + add, Quaternion.identity);

                canBeDamaged = false;
                if (health <= 0)
                {
                    canBeDamaged = false;
                    isHurt = true;
                    int rand = Random.Range(0, 2);
                    StartCoroutine(waitAfterDead(this.gameObject));
                    currentState = EnemyState.dead;
                    Instantiate(xp, transform.position, Quaternion.identity);
                    switch (rand)
                    {
                        case 0:
                            Instantiate(coin, transform.position, Quaternion.identity);
                            break;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Instantiate(parts[i], transform.position, Quaternion.identity);
                    }
                    var smokes = Instantiate(smoke, transform.position, Quaternion.identity);
                    Destroy(smokes, 0.5f);
                    Destroy(gameObject, 5f);
                    var BloodSplsh = Instantiate(splashBlood, transform.position, Quaternion.identity);
                    Destroy(BloodSplsh, 1f);
                }
                else
                {
                    int rand = Random.Range(0, 10);
                    var splsh = Instantiate(splash[rand], transform.position, Quaternion.identity);
                    Destroy(splsh, 5f);

                    isHurt = true;
                    //animator.SetBool("hurt", true);
                    StartCoroutine(waitAfterHurt());
                    currentState = EnemyState.stagger;

                }
                GameObject Blood = Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(Blood, 5f);
            }
        }
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        //animator.SetBool("hurt", false);

        canBeDamaged = true;
    }

    IEnumerator waitAfterattack()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("attacking", false);

    }



    IEnumerator waitAfterDead(GameObject gameObject)
    {

        yield return new WaitForSeconds(0.25f);
       // GameObject dead = Instantiate(deadLightFish, transform.position, Quaternion.identity);
        gameObject.SetActive(false);


    }

}

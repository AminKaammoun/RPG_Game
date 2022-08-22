using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crab : Enemy
{
    public Transform target;
    private float chaseRadius = 50f;
    private float attackRadius = 1f;
    private bool faceLeft = true;
    private Rigidbody2D rb2D;
    public AudioSource hurtAudio;
    public AudioSource BowHurtAudio;

    public SpriteRenderer Crab;
    private bool isHurt;

    public GameObject slashEff;
    public GameObject blood;
    public GameObject coin;
    public GameObject xp;
    public GameObject damageText;
    public GameObject[] splash;
    public GameObject[] part;
    public GameObject splashBlood;

    private bool canBeDamaged = true;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        rb2D = GetComponent<Rigidbody2D>();
        currentState = EnemyState.idle;
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
        }
    }
    void checkDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {

                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

                //changeAnim(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime) - transform.position);
                rb2D.MovePosition(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime));
                animator.SetBool("walk", true);

                currentState = EnemyState.walk;
            }
        }
        else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            animator.SetBool("walk", false);
            currentState = EnemyState.idle;
        }
        else if (Vector3.Distance(target.position, transform.position) < 1f)
        {
            currentState = EnemyState.attack;
            animator.SetBool("attack", true);
            StartCoroutine(returnAfterAttack());
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
    IEnumerator returnAfterAttack()
    {
        yield return new WaitForSeconds(0.28f);
        currentState = EnemyState.walk;
        animator.SetBool("attack", false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {
            if (canBeDamaged)
            {
                if (collision.gameObject.CompareTag("hitBox"))
                {
                    defence = 400;
                }
                else if (collision.gameObject.CompareTag("Arrow"))
                {
                    defence = 1000;
                }
                float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                float damage = attack * (100 / (100 + defence));
                TakeDamage((int)damage);

                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(damageText, transform.position + add, Quaternion.identity);
                int rand1 = Random.Range(0, 10);
                var splsh = Instantiate(splash[rand1], transform.position, Quaternion.identity);
                Destroy(splsh, 5f);
                canBeDamaged = false;
                
               
                if (health <= 0)
                {
                    canBeDamaged = false;
                    isHurt = true;
                    int rand = Random.Range(0, 2);
                    Crab.color = new Color(1, 0, 0, 1);
                    StartCoroutine(waitAfterDead());
                    currentState = EnemyState.dead;
                    Instantiate(xp, transform.position, Quaternion.identity);
                    switch (rand)
                    {
                        case 0:
                            Instantiate(coin, transform.position, Quaternion.identity);
                            break;
                    }

                    Destroy(gameObject, 5f);
                    Instantiate(part[0], transform.position, Quaternion.identity);
                    Instantiate(part[1], transform.position, Quaternion.identity);
                    Instantiate(part[2], transform.position, Quaternion.identity);
                    Instantiate(part[3], transform.position, Quaternion.identity);
                    var BloodSplsh = Instantiate(splashBlood, transform.position, Quaternion.identity);
                    Destroy(BloodSplsh, 1f);
                }
                else
                {

                    Crab.color = new Color(1, 0, 0, 1);
                    isHurt = true;
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
        Crab.color = new Color(1, 1, 1, 1);
        canBeDamaged = true;
    }
    IEnumerator waitAfterDead()
    {
        yield return new WaitForSeconds(0.25f);
        this.gameObject.SetActive(false);
    }
}


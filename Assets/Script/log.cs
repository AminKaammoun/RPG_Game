using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : Enemy
{
    private Rigidbody2D rb2D;

    private Transform target;
    public float chaseRadius;
    public float attackRadius;

    //public Transform homePosition;
    public SpriteRenderer Log;
    public GameObject blood;
    public GameObject xp;
    public GameObject coin;
    public GameObject slashEff;
    public GameObject damage;
    public GameObject[] grass;
    public GameObject[] parts;
    public GameObject smoke;

    public AudioSource hurtAudio;

    public bool isHurt;
    private bool canBeDamaged = true;


    // Start is called before the first frame update
    void Start()
    {

        rb2D = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        Log = GetComponent<SpriteRenderer>();

        currentState = EnemyState.idle;
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        if (isHurt)
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

    }
    void checkDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {


                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

                changeAnim(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime) - transform.position);
                rb2D.MovePosition(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime));
                animator.SetBool("wakeUp", true);

                currentState = EnemyState.walk;
            }
        }
        else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            animator.SetBool("wakeUp", false);
            currentState = EnemyState.idle;
        }
    }

    private void setAnimFloat(Vector2 setVector)
    {
        animator.SetFloat("moveX", setVector.x);
        animator.SetFloat("moveY", setVector.y);
    }

    private void changeAnim(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                setAnimFloat(Vector2.right);
            }
            else if (direction.x < 0)
            {
                setAnimFloat(Vector2.left);
            }
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if (direction.y > 0)
            {
                setAnimFloat(Vector2.up);
            }
            else if (direction.y < 0)
            {
                setAnimFloat(Vector2.down);
            }
        }
    }

    IEnumerator waitAfterDead()
    {
        yield return new WaitForSeconds(0.25f);
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("ultSlash") || collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5") || collision.gameObject.CompareTag("windUlt") || collision.gameObject.CompareTag("thunderStrike"))
        {
            if (canBeDamaged)
            {
                if (collision.gameObject.CompareTag("hitBox"))
                {
                    damageText.num = 0;
                    defence = 300;
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    GameController.ultValue += 0.5f;
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("ultSlash"))
                {
                    damageText.num = -1;
                    defence = 300;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + (GameController.skill1Level * 10);
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("rockUlt"))
                {
                    damageText.num = -2;
                    defence = 300;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + (GameController.skill2Level * 10);
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5"))
                {
                    damageText.num = -3;
                    defence = 300;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + (GameController.skill3Level * 10 * 1.2f);
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("windUlt"))
                {
                    damageText.num = -4;
                    defence = 300;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + (GameController.skill4Level * 10 * 1.2f);
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("thunderStrike"))
                {
                    damageText.num = -5;
                    defence = 300;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.5f;
                    damage = damage + (GameController.skill5Level * 10 * 1.5f);
                    TakeDamage((int)damage);
                }


                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(damage, transform.position + add, Quaternion.identity);
                Instantiate(grass[0], transform.position, Quaternion.identity);
                Instantiate(grass[1], transform.position, Quaternion.identity);
                Instantiate(grass[2], transform.position, Quaternion.identity);
                Instantiate(grass[3], transform.position, Quaternion.identity);
                Instantiate(grass[4], transform.position, Quaternion.identity);
                Instantiate(grass[5], transform.position, Quaternion.identity);
                canBeDamaged = false;
                if (health <= 0)
                {
                    canBeDamaged = false;
                    isHurt = true;
                    int rand = Random.Range(0, 2);
                    Log.color = new Color(255f, 0f, 0f, 255f);
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
                    for (int i = 0; i < 6; i++)
                    {
                        Instantiate(parts[i], transform.position, Quaternion.identity);
                    }
                    var smokes = Instantiate(smoke, transform.position, Quaternion.identity);
                    Destroy(smokes, 0.5f);
                }
                else
                {

                    Log.color = new Color(255f, 0f, 0f, 255f);
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
        Log.color = new Color(255f, 255f, 255f, 255f);
        canBeDamaged = true;
    }

}


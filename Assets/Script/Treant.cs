using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treant : Enemy
{
    private Transform target;
    public float chaseRadius;
    public float attackRadius;
    private Rigidbody2D rb2D;
    public Renderer treant;
    public GameObject blood;
    public GameObject xp;
    public GameObject coin;
    public GameObject slashEff;

    private bool isHurt;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        if (isHurt)
        {

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {
            if (health <= 0)
            {
                int rand = Random.Range(0, 2);
                treant.material.color = new Color(1, 0.5f, 0.5f, 1);
                StartCoroutine(waitAfterDead());
                currentState = EnemyState.dead;
                Instantiate(xp, transform.position, Quaternion.identity);
                switch (rand)
                {
                    case 0:
                        Instantiate(coin, transform.position, Quaternion.identity);
                        break;
                }
                health = 100;
                Destroy(gameObject, 5f);

            }
            else
            {
                TakeDamage(1);
                treant.material.color = new Color(1, 0.5f, 0.5f, 1);
                isHurt = true;
                StartCoroutine(waitAfterHurt());
                currentState = EnemyState.stagger;

            }
            GameObject Blood = Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(Blood, 5f);
        }
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        treant.material.color = new Color(1, 1f, 1f, 1);

    }
    IEnumerator waitAfterDead()
    {
        yield return new WaitForSeconds(0.25f);
        this.gameObject.SetActive(false);
    }

}

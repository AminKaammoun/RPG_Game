using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : Enemy
{
    private Rigidbody2D rb2D;

    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    //public Transform homePosition;
    public Renderer Log;
    public GameObject blood;
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
            if(direction.x > 0)
            {
                setAnimFloat(Vector2.right);
            }else if (direction.x < 0)
            {
                setAnimFloat(Vector2.left);
            }
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if(direction.y > 0)
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
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {
            if (health <= 0)
            {
               
                Log.material.color = new Color(1, 0.5f, 0.5f, 1);
                StartCoroutine(waitAfterDead());
                currentState = EnemyState.dead;
               
                Destroy(gameObject, 5f);
               
            }
            else
            {
                TakeDamage(1);
                Log.material.color = new Color (1,0.5f,0.5f,1);
              
               
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
        Log.material.color = new Color(1, 1f, 1f, 1);

    }

}


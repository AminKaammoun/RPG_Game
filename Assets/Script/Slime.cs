using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    //public Transform homePosition;
    public Rigidbody2D player;
    public GameObject blood;
    [SerializeField] SpriteRenderer spriteRenderer;
    private bool faceLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        checkDirection();
        if (health <= 0)
        {
            animator.SetBool("dead", true);
            StartCoroutine(waitAfterDead());
        }
    
        if(Vector3.Distance(target.position, transform.position) <= 1f)
        {
            animator.SetBool("attacking", true);
            StartCoroutine(waitAfterattack());
            currentState = EnemyState.attack;
        }
    }

    void checkDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position)> attackRadius) {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            animator.SetBool("moving", true);
            currentState = EnemyState.walk;
        }
        else
        {
            animator.SetBool("moving", false);
            currentState = EnemyState.idle;
        }
    }

    void checkDirection()
    {
        if(target.position.x > transform.position.x && faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = false;
        }
        else if (target.position.x < transform.position.x && !faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = true;
        }
    }

  
    IEnumerator waitAfterDead()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox"))
        {
            TakeDamage(1);
            animator.SetBool("hurt", true);
            StartCoroutine(waitAfterHurt());
            currentState = EnemyState.stagger;
            Instantiate(blood, transform.position, Quaternion.identity);
        }     
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("hurt", false);

    }

    IEnumerator waitAfterattack()
    {
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("attacking", false);
    }
}

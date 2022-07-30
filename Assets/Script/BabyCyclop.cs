using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyCyclop : Enemy
{
    public Rigidbody2D rb2D;
    private Transform target;
    public Renderer baby;
    public GameObject blood;

    private bool isHurt = false;
    public GameObject slashEff;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        health = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject, 0.1f);
        }
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

        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        changeAnim(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime) - transform.position);
        rb2D.MovePosition(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime));
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
        if (collision.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {
            currentState = EnemyState.stagger;
            isHurt = true;
            var bloods = Instantiate(blood, transform.position, Quaternion.identity);
            baby.material.color = new Color(1, 0.5f, 0.5f, 1);
            StartCoroutine(waitAfterHurt());
            //this.gameObject.SetActive(false);
            Destroy(bloods, 3f);
            TakeDamage(2);
        }
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        baby.material.color = new Color(1, 1f, 1f, 1);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigRockPet : MonoBehaviour
{
    private Transform target;
    private float moveSpeed = 4f;
    private Animator animator;
    private float stopRadius = 1.5f;
    float TimeBtwFollow = 0.25f;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > target.transform.position.x)
        {
            rend.flipX = true;
        }
        else
        {
            rend.flipX = false;
        }

        if (Vector3.Distance(target.position, transform.position) > stopRadius)
        {
            if (TimeBtwFollow <= 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                animator.SetBool("walk", true);
            }
            else
            {
                TimeBtwFollow -= Time.deltaTime;
            }
        }
        else
        {
            animator.SetBool("walk", false);
            TimeBtwFollow = 0.25f;
        }
    }

}

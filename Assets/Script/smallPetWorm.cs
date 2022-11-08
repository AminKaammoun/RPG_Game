using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallPetWorm : MonoBehaviour
{
    private Transform target;
    private float moveSpeed = 3f;
    private Animator animator;
    private float stopRadius = 1f;
    float TimeBtwFollow = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) > stopRadius)
        {
            if (TimeBtwFollow <= 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                animator.SetBool("walk", true);
               
                changeAnim(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime) - transform.position);
            }
            else
            {
                TimeBtwFollow -= Time.deltaTime;
            }
        }
        else
        {
            animator.SetBool("up", true);
            animator.SetBool("walk", false);
            TimeBtwFollow = 0.25f;
        }
    }

    private void setAnimFloat(Vector2 setVector)
    {
        animator.SetFloat("moveX", setVector.x);
       
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
       
    }
}

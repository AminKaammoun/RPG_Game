using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigRedDragon : MonoBehaviour
{
    private Transform target;
    private float moveSpeed = 4f;
    private Animator animator;
    private float stopRadius = 1.5f;
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
                changeAnim(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime) - transform.position);
            }
            else
            {
                TimeBtwFollow -= Time.deltaTime;
            }
        }
        else
        {
            TimeBtwFollow = 0.25f;
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum playerState
{
    idle,
    walk,
    attack,
    stagger,
    mine
}

public enum playerWeapon
{
    hand,
    sword,
    bow
}
public class player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2D;
    private playerState currentState;
    private Vector3 change;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);

    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == playerState.walk)
        {

            if (change != Vector3.zero)
            {
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("moving", true);
            }
            else
            {
                currentState = playerState.idle;
                animator.SetBool("moving", false);
            }
        }

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Vector3 direction = change.normalized;
        rb2D.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }
}

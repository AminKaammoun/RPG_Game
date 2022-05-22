using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState { 
    
    walk,
    attack
}

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator animator;
    public PlayerState currentState;
    public float speed;
    public float health;
    public Renderer rend;
    private Color colorToTurnTo;

    private Vector3 change;

    // Start is called before the first frame update
    
    void Start()
    {
        currentState = PlayerState.walk;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
        colorToTurnTo = new Color(1, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
       
        if (Input.GetButtonDown("Attack") && currentState != PlayerState.attack)
        {
           
            StartCoroutine(waitAttack());
        }

        if (currentState == PlayerState.walk)
        {

            if (change != Vector3.zero)
            {
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("moving", true);
            }
            else
            {
                animator.SetBool("moving", false);
            }
        }
    }

    void FixedUpdate() 
    {
        Vector3 direction = change.normalized;
        rb2D.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }

    IEnumerator waitAttack()
    {
        
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(0.33f);
        currentState = PlayerState.walk;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            rend.material.color = colorToTurnTo;
            StartCoroutine(returnColor());
        }
    }

    IEnumerator returnColor()
    {
        yield return new WaitForSeconds(0.2f);
        rend.material.color = new Color(1, 1, 1, 1);
    }

}

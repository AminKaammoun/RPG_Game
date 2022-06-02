using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    idle,
    walk,
    attack,
    stagger
}

public enum PlayerWeapon
{
    sword,
    bow
}

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public Rigidbody2D bow;
    private Animator animator;
    public PlayerState currentState;
    public float speed = 5f;
    public PlayerWeapon currentWeapon;
    public InventoryObject inventory;

    public static float health;
    private float MaxHealth = 100;

    private float PosX;
    private float PosY;

    public Renderer rend;
    private Color colorToTurnTo;

    public HealthBar healthbar;
    private Vector3 change;

    public GameObject Bow;
    public GameObject HealEffect;

    public static bool invIsOpen = false;
    public static bool isHealed = false;
    public static bool healthIsMax = true;



    // Start is called before the first frame update

    void Start()
    {

        currentState = PlayerState.idle;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
        colorToTurnTo = new Color(1, 0, 0, 1);
        PosX = transform.position.x;

        health = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 100)
        {
            health = 100;
            healthIsMax = true;
        }
        else
        {
            healthIsMax = false;
        }
        

        if (isHealed)
        {
            GameObject healEff = Instantiate(HealEffect, transform.position, Quaternion.identity);
            isHealed = false;
            Destroy(healEff, 5f);
        }


        healthbar.SetHealth(health);
        if (!invIsOpen)
        {
            if (Input.GetKeyDown("1"))
            {
                currentWeapon = PlayerWeapon.sword;
                Bow.SetActive(false);
            }
            else if (Input.GetKeyDown("2"))
            {
                currentWeapon = PlayerWeapon.bow;
                Bow.SetActive(true);
            }



            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");


            if (currentWeapon == PlayerWeapon.sword)
            {
                if (Input.GetButtonDown("Attack") && currentState != PlayerState.attack)
                {

                    StartCoroutine(waitAttack());
                }
            }
        }

        checkIfPlayerIsMoving(PosX, PosY);



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
                currentState = PlayerState.idle;
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


    IEnumerator returnColor()
    {
        yield return new WaitForSeconds(0.2f);
        rend.material.color = new Color(1, 1, 1, 1); //1,1,1,1 white with 255 transparency

    }
    public void Knock(Rigidbody2D rb2d, float knockTime)
    {
        StartCoroutine(KnockCo(rb2d, knockTime));

        rend.material.color = colorToTurnTo;

        StartCoroutine(returnColor());
    }

    private IEnumerator KnockCo(Rigidbody2D rb2d, float KnockTime)
    {
        if (rb2d != null)
        {
            yield return new WaitForSeconds(KnockTime);
            rb2d.velocity = Vector2.zero;

            rb2d.velocity = Vector2.zero;
        }
    }


    public void TakeDamage(float damage)
    {
        health -= damage;
        healthbar.SetHealth(health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
        else if (collision.CompareTag("BringerOfDeath"))
        {
            TakeDamage(20);
        }else if (collision.CompareTag("log"))
        {
            TakeDamage(10);
        }
    }
    void checkIfPlayerIsMoving(float PosX, float PosY)
    {
        if (PosX > transform.position.x || PosX < transform.position.x || PosY > transform.position.y || PosY < transform.position.y)
        {
            currentState = PlayerState.walk;
            PosX = transform.position.x;
            PosY = transform.position.y;
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}

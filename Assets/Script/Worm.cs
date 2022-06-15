using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WormState
{
    
    walk,
    attack,
    stagger,
    dead,
    stun
}
public class Worm : MonoBehaviour
{
    public Vector3 target;
    public float speed = 2f;
   
    public SpriteRenderer worm;
    private float TimeBtwAttack;
    public float startTime = 1f;
    public Animator anim;
    public GameObject fireBall;
    public GameObject wormEnemy;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject chest;
   

    public int counter = 0;
    public float health = 100f;
    public WormState currentState;

    public bool chestIsInstantiated;


    // Start is called before the first frame update
    void Start()
    {
        currentState = WormState.walk;
        target = new Vector3(112.9f, 75.77f, 0f);
        TimeBtwAttack = startTime;
        chestIsInstantiated = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            anim.SetBool("die", true);
            currentState = WormState.dead;
            CameraMovement.bigShake = true;
            Time.timeScale = 0.5f;
            Destroy(this.gameObject,1.5f);
            Instantiate(chest, transform.position, Quaternion.identity);
            StartCoroutine(backFromSlowMo());
            health = 1;
            
        }
        if (counter >= 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(106.3624f, 69.12473f, 0f), 10 * Time.deltaTime);
            anim.SetBool("stun", true);
           
            currentState = WormState.stun;
            StartCoroutine(backFromStun());
           
        }
       
        if (currentState == WormState.walk)
        {
            
            if (TimeBtwAttack <= 0)
            {
                anim.SetBool("attack", true);
                if (worm.flipX)
                {
                    StartCoroutine(waitBeforeShooting(spawn2));
                    counter++;
                }
                else
                {
                    StartCoroutine(waitBeforeShooting(spawn1));
                    counter++;
                }
                TimeBtwAttack = Random.Range(1, 5);
                StartCoroutine(backToWalk());
            }
            else
            {
                TimeBtwAttack -= Time.deltaTime;
            }

            transform.position = Vector3.MoveTowards(transform.position, target,  speed * Time.deltaTime);
            if (transform.position.x == 101.15f)
            {
                worm.flipX = false;
                target = new Vector3(112.9f, 75.77f, 0f);
            }
            else if (transform.position.x == 112.9f)
            {
                worm.flipX = true;
                target = new Vector3(101.15f, 75.77f, 0f);
            }
            
        }
    }

   IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
    }
    IEnumerator backToWalk()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("attack", false);
    }
    IEnumerator waitBeforeShooting(GameObject spawn)
    {
        yield return new WaitForSeconds(1f);
        Instantiate(fireBall, spawn.transform.position, Quaternion.identity);
    }
    IEnumerator backFromStun()
    {
        yield return new WaitForSeconds(5f);
        anim.SetBool("stun", false);
        currentState = WormState.walk;
        counter = 0;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(106.3624f, 75.54301f, 0f), 10 * Time.deltaTime);
    }
    IEnumerator backFromStagger()
    {
        yield return new WaitForSeconds(0.18f);
        anim.SetBool("stagger", false);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hitBox") && currentState == WormState.stun)
        {
            CameraMovement.shake = true;
            health -= 5f;
            StartCoroutine(backFromStagger());
            currentState = WormState.stagger;
            anim.SetBool("stagger", true);
        }
    }
}

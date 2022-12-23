using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum LizardState
{

    walk,
    attack,
    stagger,
    dead,
    stun,
    rage,
    rage2
}

public class lizard : MonoBehaviour
{
    private LizardState currentState;
    private float speed = 3f;

    public Animator anim;
    private SpriteRenderer Lizard;
    private float TimeBtwBatSpawn;

    private Vector3 target;

    public GameObject bat;
    private bool canBeDamaged = false;
    public GameObject Shield;
    private int batCounter = 0;
    private int batsToSpawn = 5;
    // Start is called before the first frame update
    void Start()
    {
        currentState = LizardState.walk;
        target = new Vector3(92.54f, 245.32f, 0f);
        Lizard = GetComponent<SpriteRenderer>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeBtwBatSpawn <= 0)
        {
            if (batCounter <= batsToSpawn)
            {
                int rand = Random.Range(0, 4);
                switch (rand)
                {
                    case 0:
                        Instantiate(bat, new Vector3(76.54f, 241.26f, 0f), Quaternion.identity);
                        batCounter++;
                        break;
                    case 1:
                        Instantiate(bat, new Vector3(76.54f, 236.21f, 0f), Quaternion.identity);
                        batCounter++;
                        break;
                    case 2:
                        Instantiate(bat, new Vector3(94.51f, 236.21f, 0f), Quaternion.identity);
                        batCounter++;
                        break;
                    case 3:
                        Instantiate(bat, new Vector3(94.51f, 241.16f, 0f), Quaternion.identity);
                        batCounter++;
                        break;
                }
               
            }
            int rand1 = Random.Range(1, 5);
            TimeBtwBatSpawn = rand1;
        }
        else
        {
            TimeBtwBatSpawn -= Time.deltaTime;
        }

        if (currentState == LizardState.walk)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if (transform.position.x == 92.54f)
            {
                target = new Vector3(78.53f, 245.32f, 0f);
                Lizard.flipX = true;
            }
            else if (transform.position.x == 78.53f)
            {
                target = new Vector3(92.54f, 245.32f, 0f);
                Lizard.flipX = false;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            if (canBeDamaged)
            {

            }
            else
            {
                var shield = Instantiate(Shield, transform.position, Quaternion.identity);
                Destroy(shield, 0.5f);
            }
            
        }
        
    }
    
}

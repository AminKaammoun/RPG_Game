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


    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        currentState = LizardState.walk;
        target = new Vector3(92.54f, 245.32f, 0f);
        Lizard = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == LizardState.walk)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            //anim.SetBool("walk", true);
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

            /* if (TimeBtwShoot <= 0)
             {
                 Instantiate(Projectile, transform.position, Quaternion.identity);
                 numberOfProjectiles++;
                 StartTime = Random.Range(0, 3);
                 TimeBtwShoot = StartTime;
             }
             else
             {
                 TimeBtwShoot -= Time.deltaTime;
             }*/
        }
    }
}

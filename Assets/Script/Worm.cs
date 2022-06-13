using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public Vector3 target;
    public float speed = 2f;
    public SpriteRenderer worm;
    private float TimeBtwAttack;
    public float startTime = 3f;
    public Animator animator;
    public GameObject fireBall;
    public GameObject wormEnemy;
    public GameObject spawn1;
    public GameObject spawn2;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(112.9f, 75.77f, 0f);
        TimeBtwAttack = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBtwAttack <= 0)
        {
            animator.SetBool("attack", true);
            if (worm.flipX)
            {
                StartCoroutine(waitBeforeShooting(spawn2));
            }
            else
            {
                StartCoroutine(waitBeforeShooting(spawn1));
            }
            TimeBtwAttack = Random.Range(1, 5);
            StartCoroutine(backToWalk());
        }
        else
        {
            TimeBtwAttack -= Time.deltaTime;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
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

    IEnumerator backToWalk()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("attack", false);
    }
    IEnumerator waitBeforeShooting(GameObject spawn)
    {
        yield return new WaitForSeconds(1f);
        Instantiate(fireBall, spawn.transform.position, Quaternion.identity);
    }
}

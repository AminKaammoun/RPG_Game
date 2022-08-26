using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    private float speed1 = 10f;
    private float speed2 = 20f;
    private Rigidbody2D rb;
    private float timer = 2f;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.gravityScale > 0)
        {
            int rand = Random.Range(0, 2);
            switch (rand)
            {
                case 0:
                    transform.position += -1 * transform.right * speed1 * Time.deltaTime;
                    break;
                case 1:
                    transform.position += transform.right * speed1 * Time.deltaTime;
                    break;
            }
            transform.position += transform.up * speed2 * Time.deltaTime;
            StartCoroutine(removeGravity());
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (timer <= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed2 * Time.deltaTime);
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
    IEnumerator removeGravity()
    {
        float rand = Random.Range(0.2f, 0.3f);
        yield return new WaitForSeconds(rand);
        rb.gravityScale = 0f;
    }
}

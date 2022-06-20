using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private float speed1 = 10f;
    private float speed2 = 20f;
    private Rigidbody2D rb;
    private float timer = 2f;
    public Transform target;

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
            transform.position += -1*transform.right * speed1 * Time.deltaTime;
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
        yield return new WaitForSeconds(0.25f);
        rb.gravityScale = 0f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour
{
    private float speed1 = 5f;
    private float speed2 = 10f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5f);
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
                    transform.position += transform.right * speed1 * Time.deltaTime;
                    transform.position += transform.up * speed2 * Time.deltaTime;
                    StartCoroutine(removeGravity());
                    break;
                case 1:
                    transform.position += -1 * transform.right * speed1 * Time.deltaTime;
                    transform.position += transform.up * speed2 * Time.deltaTime;
                    StartCoroutine(removeGravity());
                    break;
            }

        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }



    }
    IEnumerator removeGravity()
    {
        float rand = Random.Range(0.2f, 0.3f);
        yield return new WaitForSeconds(rand);
        rb.gravityScale = 0f;
    }
}

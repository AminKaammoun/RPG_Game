using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabParts : MonoBehaviour
{
    private float speed = 10f;

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
            int rand = Random.Range(0, 4);
            gameObject.transform.Rotate(0, 0, +5);
            switch (rand)
            {
                case 0:
                    transform.position += transform.right * speed * Time.deltaTime;
                    StartCoroutine(removeGravity());
                    break;
                case 1:
                    transform.position += -1 * transform.right * speed * Time.deltaTime;
                    StartCoroutine(removeGravity());
                    break;
                case 2:
                    transform.position += -1 * transform.up * speed * Time.deltaTime;
                    StartCoroutine(removeGravity());
                    break;
                case 3:
                    transform.position += transform.up * speed * Time.deltaTime;
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
        float rand = Random.Range(0.5f, 0.6f);
        yield return new WaitForSeconds(rand);
        rb.gravityScale = 0f;
    }

}

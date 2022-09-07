using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull : MonoBehaviour
{

    private float bulletForce = 5f;
    private Rigidbody2D rb;
    private Transform Target;
    private bool follow = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(startFollowing());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (follow)
        {
            if (this.gameObject.CompareTag("skull1"))
            {
                try
                {
                    Vector3 lookDir = skullGroup.logs[0].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.right, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[0].transform.position, 5f * Time.deltaTime);
                }
                catch
                {
                    rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
                }
            }
            else if (this.gameObject.CompareTag("skull2"))
            {
                try
                {
                    Vector3 lookDir = skullGroup.logs[1].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.right, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[1].transform.position, 5f * Time.deltaTime);
                }
                catch
                {
                    rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
                }
            }
            else if (this.gameObject.CompareTag("skull3"))
            {
                try
                {
                    Vector3 lookDir = skullGroup.logs[2].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.right, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[2].transform.position, 5f * Time.deltaTime);
                }
                catch
                {
                    rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
                }
            }
            else if (this.gameObject.CompareTag("skull4"))
            {
                try
                {
                    Vector3 lookDir = skullGroup.logs[3].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.right, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[3].transform.position, 5f * Time.deltaTime);
                }
                catch
                {
                    rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
                }
            }
            else if (this.gameObject.CompareTag("skull5"))
            {
                try
                {
                    Vector3 lookDir = skullGroup.logs[4].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.right, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[4].transform.position, 5f * Time.deltaTime);
                }
                catch
                {
                    rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
                }
            }
        }
        else
        {
            rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
        }
    }

    IEnumerator startFollowing()
    {
        yield return new WaitForSeconds(0.5f);
        follow = true;
    }

    IEnumerator skullDie()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("log"))
        {
            animator.SetBool("die", true);
            StartCoroutine(skullDie());
        }
    }
}

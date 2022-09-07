using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill4 : MonoBehaviour
{
    private float bulletForce = 20f;
    private Rigidbody2D rb;

    private bool follow = false;
    private Animator animator;

    public GameObject waterSplash;
    public GameObject waterSplash1;

    private float TimeBtwSpawn;
    private float startTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(startFollowing());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (follow)
        {
            try
            {

                if (skullGroup.logs[0].activeSelf)
                {
                    Vector3 lookDir = skullGroup.logs[0].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.up, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[0].transform.position, bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }
                }
                else if (skullGroup.logs[1].activeSelf)
                {
                    Vector3 lookDir = skullGroup.logs[1].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.up, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[1].transform.position, bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }
                }
                else if (skullGroup.logs[2].activeSelf)
                {
                    Vector3 lookDir = skullGroup.logs[2].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.up, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[2].transform.position, bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }
                }
                else if (skullGroup.logs[3].activeSelf)
                {
                    Vector3 lookDir = skullGroup.logs[3].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.up, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[3].transform.position, bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }

                }
                else if (skullGroup.logs[4].activeSelf)
                {
                    Vector3 lookDir = skullGroup.logs[4].transform.position - this.gameObject.transform.position;
                    float angle = Vector2.SignedAngle(Vector2.up, lookDir);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    transform.position = Vector3.MoveTowards(transform.position, skullGroup.logs[4].transform.position, bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }
                }

                else
                {
                    rb.transform.Translate(Vector2.up * bulletForce * Time.deltaTime);
                    if (TimeBtwSpawn <= 0)
                    {
                        int rand = Random.Range(0, 2);
                        switch (rand)
                        {
                            case 0:
                                Instantiate(waterSplash, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Instantiate(waterSplash1, transform.position, Quaternion.identity);
                                break;
                        }

                        TimeBtwSpawn = startTime;
                    }
                    else
                    {
                        TimeBtwSpawn -= Time.deltaTime;
                    }
                }


            }
            catch { }
        }
        else
        {
            rb.transform.Translate(Vector2.up * bulletForce * Time.deltaTime);
            if (TimeBtwSpawn <= 0)
            {
                int rand = Random.Range(0, 2);
                switch (rand)
                {
                    case 0:
                        Instantiate(waterSplash, transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(waterSplash1, transform.position, Quaternion.identity);
                        break;
                }

                TimeBtwSpawn = startTime;
            }
            else
            {
                TimeBtwSpawn -= Time.deltaTime;
            }
        }
    }

    IEnumerator startFollowing()
    {
        yield return new WaitForSeconds(0.5f);
        follow = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("log"))
        {


        }
    }
}

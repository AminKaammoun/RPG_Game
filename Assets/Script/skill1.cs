using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float bulletForce = 20f;
    public GameObject waterSplash;
    public GameObject waterSplash1;

    private float TimeBtwSpawn;
    private float startTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
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


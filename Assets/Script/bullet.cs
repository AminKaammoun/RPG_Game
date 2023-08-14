using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float bulletForce = 40f;
    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shard"))
        {
            Destroy(gameObject);
        }
           
    }

}
 
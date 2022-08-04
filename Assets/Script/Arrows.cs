using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public Rigidbody2D rb;
    private float bulletForce = 40f;
    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dungeon"))
        {
            bulletForce = 0f;
            Vector2 pos = new Vector2(transform.position.x + 0.25f, transform.position.y + 0.25f);
            var smokes = Instantiate(smoke, pos, Quaternion.identity);
            Destroy(smokes, 0.5f);
        }
    }
}

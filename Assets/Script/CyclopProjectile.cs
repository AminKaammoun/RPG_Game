using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopProjectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 7f;
    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    { 
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dungeon"))
        {
            var smokes = Instantiate(smoke, transform.position, Quaternion.identity);
            this.gameObject.SetActive(false);
            Destroy(smokes, 0.5f);
            speed = 0;
        }else if (collision.CompareTag("Player"))
        {
            CameraMovement.shake = true;
            this.gameObject.SetActive(false);
        }
    }
}

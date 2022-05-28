using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bulletForce = 20f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
        Destroy(gameObject,5f);
    }
}

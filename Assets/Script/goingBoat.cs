using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goingBoat : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 2f;
   

    public GameObject emptyBoat;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
    }
    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x >= 313f)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            var boat = Instantiate(emptyBoat, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }

}

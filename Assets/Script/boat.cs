using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    private float speed = 2f;
    public bool going = true;
    private bool change = false;
    private Rigidbody2D rb;

    public Animator animator;

    public GameObject fullBoat;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x <= 165f)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            animator.SetBool("stop" , true);
            StartCoroutine(go());
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            rb.constraints = RigidbodyConstraints2D.None;

        }

        if (change)
        {
            var boat = Instantiate(fullBoat, transform.position, Quaternion.identity);
            animator.SetBool("stop", false);
            Destroy(this.gameObject);
            change = false;
        }
    }

    IEnumerator go()
    {
        yield return new WaitForSeconds(10f);
        change = true;
        
    }
}

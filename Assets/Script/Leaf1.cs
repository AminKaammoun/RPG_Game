using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf1 : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        StartCoroutine(removeGravity());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator removeGravity()
    {
        float rand = Random.Range(0.3f, 0.6f);
        yield return new WaitForSeconds(rand);
        rb.gravityScale = 0f;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        animator.SetBool("Dropped", true);
    }
}

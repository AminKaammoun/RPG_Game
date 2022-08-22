using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float projectileForce = 10f;
    private Transform target;
    public AudioSource fireBallShutDownAudio;
    public Animator animator;

    Vector3 shoot;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();

        shoot = (target.position - gameObject.transform.position).normalized;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!animator.GetBool("explode"))
        {
            rb.transform.Translate(shoot * projectileForce * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dungeon"))
        {
            animator.SetBool("explode", true);
            fireBallShutDownAudio.Play();
            Destroy(this.gameObject, 0.5f);
        }
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("explode", true);
            fireBallShutDownAudio.Play();
            Destroy(this.gameObject, 0.5f);
        }
    }
}

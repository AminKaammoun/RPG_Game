using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bulletForce = 10f;
    public Animator animator;

    public AudioSource fireBallShutDownAudio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!animator.GetBool("explode"))
        {
            rb.transform.Translate(Vector2.right * bulletForce * Time.deltaTime);
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

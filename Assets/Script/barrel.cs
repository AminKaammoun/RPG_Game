using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{

    private Animator animator;
    private AudioSource audio;
    private BoxCollider2D boxCollider;
    public GameObject divingKit;

    private bool destructed = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!destructed) { 
            if (collision.gameObject.CompareTag("hitBox"))
            {
                CameraMovement.shake = true;
                Instantiate(divingKit,transform.position, Quaternion.identity);
                animator.SetBool("destroy", true);
                audio.Play();
                boxCollider.isTrigger = true;
                destructed = true;
            } 
    }

    }
}

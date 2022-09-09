using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingArea : MonoBehaviour
{
    public bool playerInRange;
    public GameObject key;
    public bool keyPressed;
    public Animator animator;
    public AudioSource fishing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && keyPressed == false)
        {

            key.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetBool("fish", true);
                keyPressed = true;
                fishing.Play();
            }

        }
        else if (playerInRange && keyPressed == true)
        {
            key.SetActive(false);
        }
        else
        {
            key.SetActive(false);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            animator.SetBool("fish", false);
            keyPressed = false;
        }
    }
}

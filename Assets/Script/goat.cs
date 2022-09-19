using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goat : MonoBehaviour
{
    private int currentWalkAnim;
    private Animator animator;
    private float startTime;
    private float TimeBtwSwitch;
    private float speed = 3f;

    private string direction;
    public AudioSource goatSound;
    public AudioSource hurtAudio;
    private bool run = false;

    public SpriteRenderer goatSprite;
    private float health = 2;

    public GameObject meat;
    private bool die = true;

    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                animator.SetBool("eatRight", true);
                direction = "right";
                break;
            case 1:
                animator.SetBool("eatLeft", true);
                direction = "left";
                break;
            case 2:
                animator.SetBool("eatUp", true);
                direction = "up";
                break;
            case 3:
                animator.SetBool("eatDown", true);
                direction = "down";
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            switch (direction)
            {
                case "right":
                    transform.Translate(Vector2.right * Time.deltaTime * speed);
                    break;
                case "left":
                    transform.Translate(Vector2.left * Time.deltaTime * speed);
                    break;
                case "up":
                    transform.Translate(Vector2.up * Time.deltaTime * speed);
                    break;
                case "down":
                    transform.Translate(Vector2.down * Time.deltaTime * speed);
                    break;
            }
        }
        if (health <= 0 && die)
        {
            die = false;
            int rand = Random.Range(1, 3);
            for (int i = 0; i < rand; i++)
            {
                Instantiate(meat, transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject, 0.25f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {
            health--;
            int rand1 = Random.Range(0, 4);
            switch (rand1)
            {
                case 0:
                    goatSound.clip = clips[0];
                    break;
                case 1:
                    goatSound.clip = clips[1];
                    break;
                case 2:
                    goatSound.clip = clips[2];
                    break;
                case 3:
                    goatSound.clip = clips[3];
                    break;
            }
            goatSound.Play();
            hurtAudio.Play();
            animator.SetBool("run", true);
            run = true;
            StartCoroutine(stop());
            CameraMovement.shake = true;
            goatSprite.color = new Color(1, 0, 0, 1);
        }
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1f);
        run = false;
        goatSprite.color = new Color(1, 1, 1, 1);
        animator.SetBool("run", false);
    }
}
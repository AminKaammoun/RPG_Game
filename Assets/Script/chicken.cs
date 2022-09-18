using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    private float startTime = 4f;
    private float TimeBtw;
    private Animator aniamtor;
    private float speed = 0.5f;
    private int rand;

    public AudioSource chickenSound;
    public AudioSource hurtAudio;

    public SpriteRenderer chickenSprite;
    public GameObject egg;
    public GameObject chickenThigh;

    // Start is called before the first frame update
    void Start()
    {
        aniamtor = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (TimeBtw <= 0)
        {
            aniamtor.SetBool("sit", false);
            aniamtor.SetBool("walkLeft", false);
            aniamtor.SetBool("walkRight", false);
            rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    aniamtor.SetBool("walkLeft", true);
                    break;
                case 1:
                    aniamtor.SetBool("walkRight", true);
                    break;
                case 2:
                    aniamtor.SetBool("walkRight", true);
                    aniamtor.SetBool("sit", true);
                    break;
                case 3:
                    aniamtor.SetBool("walkLeft", true);
                    aniamtor.SetBool("sit", true);
                    break;
            }
            TimeBtw = startTime;
        }
        else
        {
            TimeBtw -= Time.deltaTime;
        }

        switch (rand)
        {
            case 0:
                transform.Translate(Vector2.left * Time.deltaTime * speed);
                break;
            case 1:
                transform.Translate(Vector2.right * Time.deltaTime * speed);
                break;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hitBox") || collision.gameObject.CompareTag("Arrow"))
        {

            chickenSound.Play();
            hurtAudio.Play();
            Instantiate(chickenThigh, transform.position, Quaternion.identity);
            int rand = Random.Range(0, 2);
            switch (rand)
            {
                case 0:
                    Instantiate(egg, transform.position, Quaternion.identity);
                    break;

            }
            CameraMovement.shake = true;
            chickenSprite.color = new Color(1, 0, 0, 1);
            Destroy(this.gameObject, 0.25f);
        }
    }
}

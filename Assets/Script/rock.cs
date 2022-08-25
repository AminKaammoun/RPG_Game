using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public AudioSource mineSound;
    public AudioSource stoneBreakSound;
    public AudioClip[] stoneMiningSound;

    public SpriteRenderer Rock;
    public Sprite[] rocks;
    private float health;

    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                Rock.sprite = rocks[0];
                health = 9;
                break;
            case 1:
                Rock.sprite = rocks[1];
                health = 6;
                break;
            case 2:
                Rock.sprite = rocks[2];
                health = 3;
                break;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 6)
        {
            Rock.sprite = rocks[0];
        }
        else if (health <= 6 && health > 3)
        {
            Rock.sprite = rocks[1];
        }
        else if (health <= 3 && health > 0)
        {
            Rock.sprite = rocks[2];
        }
        else
        {
            Rock.sprite = rocks[3];
            PlayerMovements.animator.SetBool("mining", false);
            Destroy(this.gameObject, 0.5f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickAxe"))
        {
            health -= 1;
            if (health == 6 || health == 3 || health == 0)
            {
                stoneBreakSound.Play();
                var Smoke = Instantiate(smoke, transform.position, Quaternion.identity);
                Destroy(Smoke, 0.5f);
            }
            int rand = Random.Range(0, 8);
            switch (rand)
            {
                case 0:
                    mineSound.clip = stoneMiningSound[0];
                    mineSound.Play();
                    break;
                case 1:
                    mineSound.clip = stoneMiningSound[1];
                    mineSound.Play();
                    break;
                case 2:
                    mineSound.clip = stoneMiningSound[2];
                    mineSound.Play();
                    break;
                case 3:
                    mineSound.clip = stoneMiningSound[3];
                    mineSound.Play();
                    break;
                case 4:
                    mineSound.clip = stoneMiningSound[4];
                    mineSound.Play();
                    break;
                case 5:
                    mineSound.clip = stoneMiningSound[5];
                    mineSound.Play();
                    break;
                case 6:
                    mineSound.clip = stoneMiningSound[6];
                    mineSound.Play();
                    break;
                case 7:
                    mineSound.clip = stoneMiningSound[7];
                    mineSound.Play();
                    break;

            }
        }
    }
}

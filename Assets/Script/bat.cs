using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : Enemy
{
   
    private float TimeBtwSpawn;
    private float speed = 1f;
    public GameObject Fireball;

    private float TimeBtwMovements = 1f;
    private bool canBeDamaged = true;
    private bool isHurt = false;

    public SpriteRenderer Bat;

    public GameObject DamageText;
   
    public GameObject blood;
    public AudioSource BowHurtAudio;

    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {

        float randX = Random.Range(76.28f, 94.74f);
        float randY = Random.Range(233.58f, 244.87f);
        target = new Vector3(randX, randY, 0f);

        int rand = Random.Range(2, 6);
        TimeBtwSpawn = rand;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHurt && PlayerMovements.currentWeapon == PlayerWeapon.bow)
        {
            BowHurtAudio.Play();
            GameObject Blood = Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(Blood, 5f);
            isHurt = false;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(TimeBtwMovements <= 0)
        {
            float randX = Random.Range(76.28f, 94.74f);
            float randY = Random.Range(233.58f, 244.87f);
            target = new Vector3(randX, randY, 0f);
            int rand = Random.Range(1, 10);
            TimeBtwMovements = (float)rand /10f ;
            
        }
        else
        {
            TimeBtwMovements -= Time.deltaTime;
        }

        if (TimeBtwSpawn <= 0)
        {
            Instantiate(Fireball, transform.position, Quaternion.identity);
            int rand = Random.Range(2, 5);
            TimeBtwSpawn = rand;
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
    IEnumerator waitAfterDead()
    {
        yield return new WaitForSeconds(0.35f);
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow") || collision.gameObject.CompareTag("ultSlash") || collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5") || collision.gameObject.CompareTag("windUlt") || collision.gameObject.CompareTag("thunderStrike"))
        {

            if (canBeDamaged)
            {
                if (collision.gameObject.CompareTag("Arrow"))
                {
                    damageText.num = 0;
                    defence = 500;
                    GameController.ultValue += 0.5f;
                    float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
                    float damage = attack * (100 / (100 + defence));
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("ultSlash"))
                {
                    damageText.num = -1;
                    defence = 500;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill1Level / 100);
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("rockUlt"))
                {
                    damageText.num = -2;
                    defence = 500;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage + damage * (GameController.skill2Level / 100);
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("skull1") || collision.gameObject.CompareTag("skull2") || collision.gameObject.CompareTag("skull3") || collision.gameObject.CompareTag("skull4") || collision.gameObject.CompareTag("skull5"))
                {
                    damageText.num = -3;
                    defence = 500;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill3Level / 100) * 1.2f;
                    TakeDamage((int)damage);

                }
                else if (collision.gameObject.CompareTag("windUlt"))
                {
                    damageText.num = -4;
                    defence = 500;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.2f;
                    damage = damage + damage * (GameController.skill4Level / 100) * 1.2f;
                    TakeDamage((int)damage);
                }
                else if (collision.gameObject.CompareTag("thunderStrike"))
                {
                    damageText.num = -5;
                    defence = 500;
                    float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
                    float damage = attack * (100 / (100 + defence));
                    damage = damage * 1.5f;
                    damage = damage + damage * (GameController.skill5Level / 100) * 1.5f;
                    TakeDamage((int)damage);
                }

                Vector3 add = new Vector3(0.1f, 0.1f, 0f);
                Instantiate(DamageText, transform.position + add, Quaternion.identity);

                canBeDamaged = false;
                if (health <= 0)
                {
                    animator.SetBool("die", true);
                    canBeDamaged = false;
                    isHurt = true;
                    int rand = Random.Range(0, 2);
                    Bat.color = new Color(255f, 0f, 0f, 255f);
                    StartCoroutine(waitAfterDead());
                    currentState = EnemyState.dead;

                    Destroy(gameObject, 5f);
                    for (int i = 0; i < 6; i++)
                    {
                        // Instantiate(parts[i], transform.position, Quaternion.identity);
                    }
                    //var smokes = Instantiate(smoke, transform.position, Quaternion.identity);
                    //Destroy(smokes, 0.5f);
                }


                else
                {

                    Bat.color = new Color(255f, 0f, 0f, 255f);
                    isHurt = true;
                    StartCoroutine(waitAfterHurt());


                }

            }
        }
    }
    IEnumerator waitAfterHurt()
    {
        yield return new WaitForSeconds(0.25f);
        Bat.color = new Color(255f, 255f, 255f, 255f);
        canBeDamaged = true;
       
    }

}

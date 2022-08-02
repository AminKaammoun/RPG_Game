using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    idle,
    walk,
    attack,
    stagger
}

public enum PlayerWeapon
{
    sword,
    bow
}

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private LayerMask dashLayerMask;
    [SerializeField] private TrailRenderer tr;

    private Rigidbody2D rb2D;
    public Rigidbody2D bow;
    private Animator animator;
    public PlayerState currentState;
    public float speed = 5f;
    public PlayerWeapon currentWeapon;
    
    public InventoryObject inventory;
    

    public static float health;
    private float MaxHealth = 100;

    private float PosX;
    private float PosY;

    public Renderer rend;
    private Color colorToTurnTo;

    public HealthBar healthbar;
    private Vector3 change;

    public GameObject Bow;
    public GameObject HealEffect;
    public GameObject SheildEffect;
    public GameObject SpeedEffect;
    public GameObject silverKeyCanvas;
    public GameObject goldKeyCanvas;
    public GameObject LevelUp;
    public GameObject plantEffect;
    public GameObject fireEffect;
    public GameObject plant1Effect;

    public AudioSource dashAudio;
    public AudioSource swingAudio;
    public AudioSource hurtAudio;
    public AudioSource silverKeyAudio;
    public AudioSource goldKeyAudio;
    public AudioSource collectCoinAudio;
    public AudioSource collectXpAudio;
    public AudioSource levelUpAudio;
    public AudioSource hurtWithShieldAudio;

    public static bool invIsOpen = false;
    
    public static bool isHealed = false;
    public static bool isSmallSheilded = false;
    public static bool isBigSheilded = false;
    public static bool isSmallSpeeded = false;
    public static bool isBigSpeeded = false;
    
    public static bool healthIsMax = false;
    public static bool isDashButtonDown;
    public static bool canDash = true;
    public static bool canBeDamaged = true;
    public static bool isLevelUp = false;

    private bool islogDamaged = false;
    private bool isFireBallDamaged = false;
    private bool isTreantDamaged = false;
    private bool isCyclopDamaged = false;
   

    // Start is called before the first frame update

    void Start()
    {
        
        currentState = PlayerState.idle;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
        colorToTurnTo = new Color(1, 0, 0, 1);
        PosX = transform.position.x;
        
        health = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);

    }

  
    // Update is called once per frame
    void Update()
    {
      
        if (health >= 100)
        {
            health = 100;
            healthIsMax = true;
        }
        else
        {
            healthIsMax = false;
        }
        if (isLevelUp)
        {
            GameObject levelUp = Instantiate(LevelUp) as GameObject;
            levelUp.transform.parent = this.gameObject.transform;
            levelUp.transform.position = transform.position;
            levelUpAudio.Play();
            isLevelUp = false;
            Destroy(levelUp, 1f);
        }

        if (isHealed)
        {
            
            GameObject healEff = Instantiate(HealEffect) as GameObject;
            healEff.transform.parent = this.gameObject.transform;
            healEff.transform.position = transform.position;
            isHealed = false;
            Destroy(healEff, 2f);
        }
        if (isSmallSheilded)
        {
            GameObject shieldEff = Instantiate(SheildEffect) as GameObject;
            shieldEff.transform.parent = this.gameObject.transform;
            shieldEff.transform.position = transform.position;
            canBeDamaged = false;
            StartCoroutine(backToNormalFromSheild());
            isSmallSheilded = false;
            Destroy(shieldEff, 5f);
        }
   
        if (isBigSheilded)
        {
            GameObject shieldEff = Instantiate(SheildEffect) as GameObject;
            shieldEff.transform.parent = this.gameObject.transform;
            shieldEff.transform.position = transform.position;
            canBeDamaged = false;
            StartCoroutine(backToNormalFromSheild());
            isBigSheilded = false;
            Destroy(shieldEff, 10f);

        }
       
      
        if (isSmallSpeeded)
        {
            speed = speed*1.5f;
            GameObject speedEff = Instantiate(SpeedEffect) as GameObject;
            speedEff.transform.parent = this.gameObject.transform;
            speedEff.transform.position = transform.position;
            StartCoroutine(backToNormalSpeed());
            isSmallSpeeded = false;
            Destroy(speedEff, 10f);
           
        }

        if (isBigSpeeded)
        {
            speed = speed * 1.5f;
            GameObject speedEff = Instantiate(SpeedEffect) as GameObject;
            speedEff.transform.parent = this.gameObject.transform;
            speedEff.transform.position = transform.position;
            StartCoroutine(backToNormalSpeed());
            isBigSpeeded = false;
            Destroy(speedEff, 20f);

        }
        if (islogDamaged || isCyclopDamaged)
        {
            GameObject plantEff = Instantiate(plantEffect) as GameObject;
            plantEff.transform.parent = this.gameObject.transform;
            plantEff.transform.position = transform.position;
            islogDamaged = false;
            isCyclopDamaged = false;
            Destroy(plantEff, 0.3f);
        }
        if (isFireBallDamaged)
        {
            GameObject fireEff = Instantiate(fireEffect) as GameObject;
            fireEff.transform.parent = this.gameObject.transform;
            fireEff.transform.position = transform.position;
            isFireBallDamaged = false;
            Destroy(fireEff, 0.3f);
        }
        if (isTreantDamaged)
        {
            GameObject plant1Eff = Instantiate(plant1Effect) as GameObject;
            plant1Eff.transform.parent = this.gameObject.transform;
            plant1Eff.transform.position = transform.position;
            isTreantDamaged = false;
            Destroy(plant1Eff, 0.3f);
        }
        
       

        healthbar.SetHealth(health);
        if (!invIsOpen || !GameController.wantTp)
        {
            if (Input.GetKeyDown("1"))
            {
                currentWeapon = PlayerWeapon.sword;
                Bow.SetActive(false);
            }
            else if (Input.GetKeyDown("2"))
            {
                currentWeapon = PlayerWeapon.bow;
                Bow.SetActive(true);
            }

            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");


            if (currentWeapon == PlayerWeapon.sword)
            {
                if (Input.GetButtonDown("Attack") && currentState != PlayerState.attack)
                {
                    swingAudio.Play();
                    StartCoroutine(waitAttack());
                }
            }
        }

        checkIfPlayerIsMoving(PosX, PosY);

        if (currentState == PlayerState.walk)
        {

            if (change != Vector3.zero)
            {
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("moving", true);
            }
            else
            {
                currentState = PlayerState.idle;
                animator.SetBool("moving", false);
            }
        }
        

        if (Input.GetKeyDown(KeyCode.R) && canDash)
        {
            isDashButtonDown = true;
            GameController.dashed = true;
            dashAudio.Play();

        }
    }

    void FixedUpdate()
    {
        Vector3 direction = change.normalized;
        rb2D.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);


        if (isDashButtonDown)
        {
            float dashAmount = 4f;
            Vector3 dashPosition = transform.position + direction * dashAmount;

            RaycastHit2D raycastHit2d = Physics2D.Raycast(transform.position, direction, dashAmount, dashLayerMask);
            if (raycastHit2d.collider != null)
            {
                dashPosition = raycastHit2d.point;
            }
            rb2D.MovePosition(dashPosition);
            isDashButtonDown = false;
            tr.emitting = true;
            StartCoroutine(waitdash());
        }

    }

    IEnumerator waitAttack()
    {
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(0.33f);
        currentState = PlayerState.walk;
    }

    IEnumerator waitdash()
    {
        yield return new WaitForSeconds(0.25f);
        tr.emitting = false;
    }
    IEnumerator returnColor()
    {
        yield return new WaitForSeconds(0.2f);
        rend.material.color = new Color(1, 1, 1, 1); //1,1,1,1 white with 255 transparency

    }
    IEnumerator backToNormalSpeed()
    {
        if (isSmallSpeeded)
        {
            yield return new WaitForSeconds(10f);
            speed = speed / 1.5f;
        }else if (isBigSpeeded)
        {
            yield return new WaitForSeconds(20f);
            speed = speed / 1.5f;
        }
    }
    IEnumerator backToNormalFromSheild()
    {
        if (isSmallSheilded)
        {
            yield return new WaitForSeconds(5f);
            canBeDamaged = true;
        }
        else if (isBigSheilded)
        {
            yield return new WaitForSeconds(10f);
            canBeDamaged = true;
        }
    }
        public void Knock(Rigidbody2D rb2d, float knockTime)
    {
        StartCoroutine(KnockCo(rb2d, knockTime));

        rend.material.color = colorToTurnTo;

        StartCoroutine(returnColor());
    }

    private IEnumerator KnockCo(Rigidbody2D rb2d, float KnockTime)
    {
        if (rb2d != null)
        {

            yield return new WaitForSeconds(KnockTime);
            rb2d.velocity = Vector2.zero;

            rb2d.velocity = Vector2.zero;
        }
    }
    private IEnumerator backAfterHit()
    {
        yield return new WaitForSeconds(0.5f);
        canBeDamaged = true;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthbar.SetHealth(health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canBeDamaged)
        {
            if (collision.CompareTag("Enemy"))
            {
                hurtAudio.Play();
                TakeDamage(10);
            }
            else if (collision.CompareTag("BringerOfDeath"))
            {
                hurtAudio.Play();
                TakeDamage(20);
            }
            else if (collision.CompareTag("log"))
            {
                hurtAudio.Play();
                islogDamaged = true;
                TakeDamage(10);
            }
            else if (collision.CompareTag("fireBall"))
            {
                hurtAudio.Play();
                isFireBallDamaged = true;
                canBeDamaged = false;
                TakeDamage(10);
                rend.material.color = colorToTurnTo;
                StartCoroutine(backAfterHit());
                StartCoroutine(returnColor());
            }
            else if (collision.CompareTag("treant"))
            {
                hurtAudio.Play();
                isTreantDamaged = true;
                TakeDamage(10);
            }else if (collision.CompareTag("cyclopProjectile"))
            {
                hurtAudio.Play();
                isCyclopDamaged = true;
                canBeDamaged = false;
                TakeDamage(10);
                rend.material.color = colorToTurnTo;
                StartCoroutine(backAfterHit());
                StartCoroutine(returnColor());
            }else if (collision.CompareTag("babyCyclop"))
            {
                hurtAudio.Play();
                TakeDamage(10);
            }
        }
        else
        {
            if (collision.CompareTag("Enemy"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("BringerOfDeath"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("log"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("fireBall"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("treant"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("cyclopProjectile"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("babyCyclop"))
            {
                hurtWithShieldAudio.Play();
            }
        }
        if (collision.CompareTag("xpLvl1"))
        {
            GameController.level.AddExp(10);
            collectXpAudio.Play();
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("coin"))
        {
            collectCoinAudio.Play();
            GameController.coins++;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("teleporter"))
        {
            GameController.wantTp = true;
        }

        if (collision.CompareTag("silverKey"))
        {
            silverKeyCanvas.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("silverKey"));
            Door1.silverKeyObtained = true;
            silverKeyAudio.Play();
        }
        if (collision.CompareTag("goldKey"))
        {
            goldKeyAudio.Play();
            goldKeyCanvas.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("goldKey"));
            Door2.goldKeyObtained = true;
        }
    }
    void checkIfPlayerIsMoving(float PosX, float PosY)
    {
        if (PosX > transform.position.x || PosX < transform.position.x || PosY > transform.position.y || PosY < transform.position.y)
        {
            currentState = PlayerState.walk;
            PosX = transform.position.x;
            PosY = transform.position.y;
        }
    }

}

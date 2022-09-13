using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public enum PlayerState
{
    idle,
    walk,
    attack,
    stagger,
    mine
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

    public static int BonusAttack;
    public static int BonusDefence;
    public static int BonusAgility;
    public static int BonusHp;
    public static int BonusSp;

    public static float attack;
    public static float defence;
    public static float agility;
    public static float hp;
    public static float Sp;

    private Rigidbody2D rb2D;
    public Rigidbody2D bow;
    public static Animator animator;
    public PlayerState currentState;
    public float speed = 5f;
    public static PlayerWeapon currentWeapon;

    public InventoryObject inventory;

    public ItemObject[] potions;

    public static float health;
    public static float MaxHealth;

    private float PosX;
    private float PosY;

    public SpriteRenderer rend;
    private Color colorToTurnTo;

    public HealthBar healthbar;
    private Vector3 change;

    public Camera mainCamera;

    public GameObject dashSmoke;

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
    public GameObject smallSlashEffect;
    public GameObject xpText;
    public GameObject xpText1;
    public GameObject coinText;
    public GameObject coinText1;
    public GameObject damageText;
    public GameObject stoneText;
    public GameObject IronStoneText;
    public GameObject CoalStoneText;
    public GameObject WoodText;
    public GameObject BlueGemStoneText;
    public GameObject RedGemStoneText;
    public GameObject YellowGemStoneText;
    public GameObject GreenGemStoneText;
    public GameObject OrangeGemStoneText;
    public GameObject HealthIsFull;
    public GameObject panel;

    public GameObject volume;
    public GameObject teleport_hit;
    public GameObject brust;
    public GameObject playerShadow;
    public GameObject ultDirection;
    public GameObject BrownUltDirection;
    public GameObject PinkUltDirection;
    public GameObject GreenUltDirection;
    public GameObject rockEffect;
    public GameObject soulEffect;
    public GameObject greenEffect;
    public GameObject redDot;
    public GameObject thunderEffect;

    public AudioSource dashAudio;
    public AudioSource swingAudio;
    public AudioSource hurtAudio;
    public AudioSource silverKeyAudio;
    public AudioSource goldKeyAudio;
    public AudioSource collectCoinAudio;
    public AudioSource collectXpAudio;
    public AudioSource levelUpAudio;
    public AudioSource hurtWithShieldAudio;
    public AudioSource slowMotionSound;
    public AudioSource collectStoneAudio;
    public AudioSource collectWoodAudio;
    public AudioSource fishCollect;

    public static bool invIsOpen = false;

    public static bool isHealed = false;
    public static bool isSmallSheilded = false;
    public static bool isBigSheilded = false;
    public static bool isSmallSpeeded = false;
    public static bool isBigSpeeded = false;

    public static bool changeCursor = false;
    public static bool healthIsMax = false;
    public static bool isDashButtonDown;
    public static bool canDash = true;
    public static bool canBeDamaged = true;
    public static bool isLevelUp = false;
    public static bool PotionInUse = false;


    private bool islogDamaged = false;
    private bool isFireBallDamaged = false;
    private bool isTreantDamaged = false;
    private bool isCyclopDamaged = false;
    private bool isCrabDamaged = false;
    private bool damagePlayer = true;

    public ItemObject AutumnLeaf;
    public ItemObject IceLeaf;
    public ItemObject FireLeaf;
    public ItemObject PlantLeaf;
    public ItemObject SakuraLeaf;
    public ItemObject Stone;
    public ItemObject IronStone;
    public ItemObject CoalStone;
    public ItemObject Wood;
    public ItemObject BlueGemStone;
    public ItemObject RedGemStone;
    public ItemObject YellowGemStone;
    public ItemObject OrangeGemStone;
    public ItemObject GreenGemStone;

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

        health = 100 + (GameController.Level * 10) + BonusHp;
        healthbar.SetMaxHealth(100 + (GameController.Level * 10) + BonusHp);

    }


    // Update is called once per frame
    void Update()
    {
        healthbar.SetMaxHealth(100 + (GameController.Level * 10) + BonusHp);
        getStats();

        Vector3 add = new Vector3(0f, 2f, 0f);
        xpText.transform.position = transform.position + add;
        if (health >= 100 + (GameController.Level * 10) + BonusHp)
        {
            health = 100 + (GameController.Level * 10) + BonusHp;
            healthIsMax = true;
        }
        else
        {
            healthIsMax = false;
        }
        if (isLevelUp)
        {
            GameController.skillPoint++;
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
            speed = speed * 1.5f;
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
        if (isCrabDamaged)
        {
            GameObject slashEff = Instantiate(smallSlashEffect) as GameObject;
            slashEff.transform.parent = this.gameObject.transform;
            slashEff.transform.position = transform.position;
            isCrabDamaged = false;
            Destroy(slashEff, 0.3f);
        }



        healthbar.SetHealth(health);
        if (!invIsOpen || !GameController.wantTp)
        {
            if (Input.GetKeyDown("1"))
            {
                changeCursor = true;
                currentWeapon = PlayerWeapon.sword;
                Bow.SetActive(false);
            }
            else if (Input.GetKeyDown("2"))
            {
                changeCursor = true;
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

        //dash
        if (Input.GetKeyDown(KeyCode.R) && canDash)
        {
            isDashButtonDown = true;
            GameController.dashed = true;
            dashAudio.Play();
            Vector3 adds = new Vector3(0f, -0.5f, 0f);
            var dashSmokes = Instantiate(dashSmoke, transform.position + adds, Quaternion.identity);
            Destroy(dashSmokes, 0.5f);
        }

        //Ult
        if (Input.GetKeyDown(KeyCode.X) && GameController.canUlt)
        {
            GameController.ultValue = 0;
            GameController.canUlt = false;
            animator.SetBool("ulting", true);
            StartCoroutine(returnFromUlt());
            slowMotionSound.Play();
            CameraMovement.longUltShake = true;
            GameController.ultPressed = true;

            Time.timeScale = 0.25f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            var Volumes = volume.GetComponent<Volume>();
            if (Volumes.profile.TryGet<ChromaticAberration>(out var chromaticAberration))
            {
                chromaticAberration.intensity.value = 1f;
            }
            Instantiate(playerShadow, transform.position, Quaternion.identity);
            switch (GameController.currentSkill)
            {
                case 0:
                    ultDirection.SetActive(true);
                    Vector3 adds = new Vector3(0f, 1.5f, 0f);
                    Instantiate(brust, transform.position, Quaternion.identity);
                    Instantiate(teleport_hit, transform.position + adds, Quaternion.identity);
                    break;

                case 1:
                    BrownUltDirection.SetActive(true);
                    Instantiate(brust, transform.position, Quaternion.identity);
                    Instantiate(rockEffect, transform.position, Quaternion.identity);
                    break;
                case 2:
                    PinkUltDirection.SetActive(true);
                    Instantiate(brust, transform.position, Quaternion.identity);
                    Instantiate(soulEffect, transform.position, Quaternion.identity);
                    break;
                case 3:
                    GreenUltDirection.SetActive(true);
                    Instantiate(brust, transform.position, Quaternion.identity);
                    Instantiate(greenEffect, transform.position, Quaternion.identity);
                    break;
                case 4:
                    redDot.SetActive(true);
                    Instantiate(brust, transform.position, Quaternion.identity);
                    Instantiate(thunderEffect, transform.position, Quaternion.identity);
                    if (Volumes.profile.TryGet<Vignette>(out var vignette))
                    {
                        vignette.rounded.value = true;
                        vignette.intensity.value = 1f;
                        vignette.smoothness.value = 1f;
                    }
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
           
            switch (GameController.ability1)
            {
                case "Big Heal Potion (potionObject)":
                    useBigHealth();
                    break;

                case "Small Health Potion (potionObject)":
                    useSmallHealth();
                    break;

                case "Big sheild Potion (potionObject)":
                    useBigShield();
                    break;

                case "Small Shield Potion (potionObject)":
                    useSmallShield();
                    break;

                case "Big Speed Potion (potionObject)":
                    useBigSpeeded();
                    break;

                case "Small Speed Potion (potionObject)":
                    useSmallSpeeded();
                    break;

            }
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
        rend.color = new Color(1, 1, 1, 1); //1,1,1,1 white with 255 transparency

    }

    IEnumerator returnFromUlt()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("ulting", false);
    }
    IEnumerator backToNormalSpeed()
    {
        if (isSmallSpeeded)
        {
            yield return new WaitForSeconds(10f);
            speed = speed / 1.5f;
            PlayerMovements.PotionInUse = false;
        }
        else if (isBigSpeeded)
        {
            yield return new WaitForSeconds(20f);
            speed = speed / 1.5f;
            PlayerMovements.PotionInUse = false;
        }
    }
    IEnumerator backToNormalFromSheild()
    {
        if (isSmallSheilded)
        {
            yield return new WaitForSeconds(5f);
            canBeDamaged = true;
            PlayerMovements.PotionInUse = false;
        }
        else if (isBigSheilded)
        {
            yield return new WaitForSeconds(10f);
            canBeDamaged = true;
            PlayerMovements.PotionInUse = false;
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
        yield return new WaitForSeconds(0.3f);
        canBeDamaged = true;
        damagePlayer = true;
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
                if (damagePlayer)
                {
                    PlayerDamage.num = 0;
                    damagePlayer = false;

                    hurtAudio.Play();
                    StartCoroutine(backAfterHit());
                    rend.color = colorToTurnTo;
                    StartCoroutine(returnColor());
                    Enemy.attack = 100;
                    GameController.ultValue += 0.5f;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = 100;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                }
            }
            else if (collision.CompareTag("BringerOfDeath"))
            {
                hurtAudio.Play();
                TakeDamage(20);
            }
            else if (collision.CompareTag("log"))
            {
                if (damagePlayer)
                {
                    PlayerDamage.num = 0;
                    Enemy.attack = 30;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    damagePlayer = false;
                    GameController.ultValue += 0.5f;
                    hurtAudio.Play();
                    islogDamaged = true;
                    float attack = Enemy.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                    rend.color = colorToTurnTo;
                    StartCoroutine(backAfterHit());
                    StartCoroutine(returnColor());

                }
            }
            else if (collision.CompareTag("fireBall"))
            {
                if (damagePlayer)
                {
                    damagePlayer = false;
                    PlayerDamage.num = 1;
                    hurtAudio.Play();
                    isFireBallDamaged = true;

                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = Worm.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                    rend.color = colorToTurnTo;
                    StartCoroutine(backAfterHit());
                    StartCoroutine(returnColor());
                }
            }
            else if (collision.CompareTag("fireBall1"))
            {
                if (damagePlayer)
                {

                    damagePlayer = false;
                    PlayerDamage.num = 0;
                    hurtAudio.Play();
                    isFireBallDamaged = true;
                    Enemy.attack = 40;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = Enemy.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                    rend.color = colorToTurnTo;
                    StartCoroutine(backAfterHit());
                    StartCoroutine(returnColor());
                }
            }
            else if (collision.CompareTag("treant"))
            {
                if (damagePlayer)
                {
                    PlayerDamage.num = 0;
                    Enemy.attack = 60;
                    damagePlayer = false;
                    GameController.ultValue += 0.5f;
                    hurtAudio.Play();
                    isTreantDamaged = true;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = Enemy.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                    rend.color = colorToTurnTo;
                    StartCoroutine(backAfterHit());
                    StartCoroutine(returnColor());
                }
            }
            else if (collision.CompareTag("cyclopProjectile"))
            {
                if (damagePlayer)
                {
                    PlayerDamage.num = 2;
                    hurtAudio.Play();
                    isCyclopDamaged = true;

                    damagePlayer = false;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = Cyclop.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                    rend.color = colorToTurnTo;
                    StartCoroutine(backAfterHit());
                    StartCoroutine(returnColor());
                }
            }
            else if (collision.CompareTag("babyCyclop"))
            {
                if (damagePlayer)
                {
                    damagePlayer = false;

                    StartCoroutine(backAfterHit());
                    rend.color = colorToTurnTo;
                    StartCoroutine(returnColor());
                    PlayerDamage.num = 0;
                    Enemy.attack = 30;
                    hurtAudio.Play();
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = Cyclop.attack;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                }
            }
            else if (collision.CompareTag("spikeRight") || collision.CompareTag("spikeLeft"))
            {
                if (damagePlayer)
                {
                    damagePlayer = false;

                    hurtAudio.Play();
                    StartCoroutine(backAfterHit());
                    rend.color = colorToTurnTo;
                    StartCoroutine(returnColor());
                    Enemy.attack = 50;

                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = 50;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                }
            }
            else if (collision.CompareTag("pusher"))
            {
                if (damagePlayer)
                {
                    damagePlayer = false;

                    hurtAudio.Play();
                    StartCoroutine(backAfterHit());
                    rend.color = colorToTurnTo;
                    StartCoroutine(returnColor());
                    Enemy.attack = 100;

                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = 100;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                }
            }
            else if (collision.CompareTag("crab"))
            {
                if (damagePlayer)
                {
                    PlayerDamage.num = 0;
                    damagePlayer = false;

                    hurtAudio.Play();
                    StartCoroutine(backAfterHit());
                    rend.color = colorToTurnTo;
                    StartCoroutine(returnColor());
                    Enemy.attack = 80;
                    isCrabDamaged = true;
                    GameController.ultValue += 0.5f;
                    var ins = Instantiate(damageText, transform.position, Quaternion.identity);
                    float attack = 100;
                    float damage = attack * (100 / (100 + PlayerMovements.defence));
                    TakeDamage((int)damage);
                }
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
            else if (collision.CompareTag("spikeRight") || collision.CompareTag("spikeLeft"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("pusher"))
            {
                hurtWithShieldAudio.Play();
            }
            else if (collision.CompareTag("crab"))
            {
                hurtWithShieldAudio.Play();
            }
        }
        if (collision.CompareTag("xpLvl1"))
        {
            GameController.level.AddExp(5);

            var xpTxt = Instantiate(xpText, transform.position, Quaternion.identity);
            collectXpAudio.Play();
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("xpLvl2"))
        {
            GameController.level.AddExp(10);

            var xpTxt = Instantiate(xpText1, transform.position, Quaternion.identity);
            collectXpAudio.Play();
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("coin"))
        {
            collectCoinAudio.Play();
            GameController.coins += 8000;
            var coinTxt = Instantiate(coinText, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("coin1"))
        {
            collectCoinAudio.Play();
            GameController.coins += 16000;
            var coinTxt = Instantiate(coinText1, transform.position, Quaternion.identity);
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
            //Door1.silverKeyObtained = true;
            silverKeyAudio.Play();
        }
        if (collision.CompareTag("goldKey"))
        {
            goldKeyAudio.Play();
            goldKeyCanvas.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("goldKey"));
            Door2.goldKeyObtained = true;
        }
        if (collision.CompareTag("Leaf"))
        {
            if (collision.gameObject.name == "AutumnLeaf(Clone)")
            {
                inventory.AddItem(AutumnLeaf, 1);
                inventory.save();
            }
            if (collision.gameObject.name == "IceLeaf(Clone)")
            {
                inventory.AddItem(IceLeaf, 1);
                inventory.save();
            }
            if (collision.gameObject.name == "FireLeaf(Clone)")
            {
                inventory.AddItem(FireLeaf, 1);
                inventory.save();
            }
            if (collision.gameObject.name == "PlantLeaf(Clone)")
            {
                inventory.AddItem(PlantLeaf, 1);
                inventory.save();
            }
            if (collision.gameObject.name == "SakuraLeaf(Clone)")
            {
                inventory.AddItem(SakuraLeaf, 1);
                inventory.save();
            }
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("minerals"))
        {
            if (collision.gameObject.name == "Stone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(Stone, 1);
                inventory.save();
                var stoneTxt = Instantiate(stoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "IronStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(IronStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(IronStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "CoalStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(CoalStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(CoalStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "Wood(Clone)")
            {
                collectWoodAudio.Play();
                inventory.AddItem(Wood, 1);
                inventory.save();
                var stoneTxt = Instantiate(WoodText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "BlueGemStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(BlueGemStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(BlueGemStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "GreenGemStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(GreenGemStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(GreenGemStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "RedGemStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(RedGemStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(RedGemStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "YellowGemStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(YellowGemStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(YellowGemStoneText, transform.position, Quaternion.identity);

            }

            if (collision.gameObject.name == "OrangeGemStone(Clone)")
            {
                collectStoneAudio.Play();
                inventory.AddItem(OrangeGemStone, 1);
                inventory.save();
                var stoneTxt = Instantiate(OrangeGemStoneText, transform.position, Quaternion.identity);

            }
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("fish"))
        {
            fishCollect.Play();
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
    public void getStats()
    {

        attack = 100 + (GameController.Level * 5) + BonusAttack;
        defence = 50 + (GameController.Level * 4) + BonusDefence;
        agility = 30 + (GameController.Level * 2) + BonusAgility;
        hp = 100 + (GameController.Level * 10) + BonusHp;
        Sp = 50 + (GameController.Level * 2) + BonusSp;

    }

    public void useBigHealth()
    {
        if (!healthIsMax)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isHealed = true;

            health += 50;
            inventory.RemoveItem(potions[0]);
            inventory.save();
        }
        else
        {
            var forgedTxt = Instantiate(HealthIsFull, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(panel.transform, false);
            Destroy(forgedTxt, 1f);
        }
    }

    public void useSmallHealth()
    {
        if (!healthIsMax)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isHealed = true;

            health += 20;
            inventory.RemoveItem(potions[1]);
            inventory.save();
        }
        else
        {
            var forgedTxt = Instantiate(HealthIsFull, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(panel.transform, false);
            Destroy(forgedTxt, 1f);
        }
    }


    public void useSmallShield()
    {
        if (!PotionInUse)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isSmallSheilded = true;
            PotionInUse = true;

            inventory.RemoveItem(potions[3]);
            inventory.save();

        }

    }
    public void useBigShield()
    {
        if (!PotionInUse)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isBigSheilded = true;
            PotionInUse = true;

            inventory.RemoveItem(potions[2]);
            inventory.save();

        }

    }
    public void useBigSpeeded()
    {
        if (!PotionInUse)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isBigSpeeded = true;
            PotionInUse = true;

            inventory.RemoveItem(potions[4]);
            inventory.save();

        }

    }

    public void useSmallSpeeded()
    {
        if (!PotionInUse)
        {
            ArrowSpawn.canShoot = true;
            changeCursor = true;
            invIsOpen = false;
            isBigSpeeded = true;
            PotionInUse = true;

            inventory.RemoveItem(potions[5]);
            inventory.save();

        }

    }

}

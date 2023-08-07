using System.Collections;
using UnityEngine;
using DG.Tweening;
using TMPro;
using Unity.Properties;

public class Cacodaemon : MonoBehaviour
{
    private float moveSpeed = 3f;
    private float desiredDistance = 7f;
    private Transform player;
    private bool faceLeft = true;
    public static float attack;

    private bool isRoaming = true;
    private bool isDashing = false;
    private bool isAttacking = false;
    private bool isRaging = false;

    private float timeBtwDash = 5f;
    private Vector3 lastKnownPlayerPosition;

    private int dashCounter = 0;
    private Animator animator;
    public GameObject projectile;
    private int projectileCounter = 0;

    private float timeBtwShoot = 1f;
    private float TimeBtwGettingPosition = 0f;

    public GameObject right;
    public GameObject left;
    public GameObject projectileStatic;

    public GameObject ghost;
    private SpriteRenderer spriteRenderer;
    private float timeBtwGhost = 0f;

    public AudioSource dash;
    private bool dashAudioPlayed = false;
    public AudioSource attackAudio;
    public AudioSource dropSound;
    public AudioSource energySound;
    public ParticleSystem particle;

    public GameObject smoke;
    private bool wasRaging = true;
    private bool hasPlayedEnergySound = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
       particle.Stop();
    }

    private void Update()
    {
        checkDirection();

        if (faceLeft)
        {
            projectileStatic.transform.position = right.transform.position;
        }
        else
        {
            Vector3 add = new Vector3(2.25f, 0, 0);
            projectileStatic.transform.position = left.transform.position - add;
        }

        
        
        
        if (!isRaging)
        {
            if (timeBtwDash < 0)
            {

                isDashing = true;
                isRoaming = false;
                lastKnownPlayerPosition = player.position;
                timeBtwDash = 5f; // Reset the dash timer
                // Store the player's position when starting to dash
            }
            else
            {
                timeBtwDash -= Time.deltaTime;
            }
        }
        else
        {
            if (TimeBtwGettingPosition < 0f)
            {
                lastKnownPlayerPosition = player.position;
                TimeBtwGettingPosition = 2f;
            }
            else
            {
                TimeBtwGettingPosition -= Time.deltaTime;
            }
        }
        Vector3 directionToPlayer = player.position - transform.position;

        if (isRoaming)
        {
            float distanceToPlayer = directionToPlayer.magnitude;

            if (distanceToPlayer > desiredDistance)
            {
                // Move the boss towards the player
                transform.position += directionToPlayer.normalized * moveSpeed * Time.deltaTime;
            }
            else if (distanceToPlayer < desiredDistance)
            {
                // Move the boss away from the player
                transform.position -= directionToPlayer.normalized * moveSpeed * Time.deltaTime;
            }
        }
        else if (isDashing)
        {
            if (timeBtwGhost < 0)
            {
                GameObject ghosting = Instantiate(ghost, transform.position, Quaternion.identity);
                spriteRenderer = ghosting.GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                if (!faceLeft)
                {
                    spriteRenderer.flipX = true;
                }
                timeBtwGhost = 0.1f;
            }
            else
            {
                timeBtwGhost -= Time.deltaTime;
            }

            if (isDashing && !dashAudioPlayed)
            {
                dash.Play();
                dashAudioPlayed = true;
            }
        
           
            Vector3 directionToLastKnownPosition = lastKnownPlayerPosition - transform.position;
            Vector3 normalizedDirectionToLastKnownPosition = directionToLastKnownPosition.normalized;

            Vector3 finalPosition = lastKnownPlayerPosition + normalizedDirectionToLastKnownPosition * 5f;

            transform.DOMove(finalPosition, 2f);

           
            if (Vector3.Distance(transform.position, lastKnownPlayerPosition) < 0.1f)
            {
                isDashing = false;
                StartCoroutine(backToRoaming());
                dashCounter++; 
                dashAudioPlayed = false; 
            }
        }

       
        if (isAttacking)
        {
            isDashing = false;
            isRoaming = false;
            animator.SetBool("attack", true);

            if (!attackAudio.isPlaying)
            {
                attackAudio.Play();
            }

            if (timeBtwShoot < 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                projectileCounter++;

                if (projectileCounter > 2)
                {
                    isAttacking = false;
                    animator.SetBool("attack", false);
                    projectileStatic.SetActive(false);
                    isRoaming = true;
                    projectileCounter = 0;
                }
                timeBtwShoot = 1.5f;
            }
            else
            {
                timeBtwShoot -= Time.deltaTime;
            }

        }
        
        if (isRaging)
        {
            Vector3 add = new Vector3(0, 6f, 0);
            transform.position = Vector3.MoveTowards(transform.position, lastKnownPlayerPosition + add, 15f * Time.deltaTime);
            GameController.cacodeamonUltEffect = true;
            GameController.attack3rd = true;
            if (!hasPlayedEnergySound)
            {
                energySound.Play();
                hasPlayedEnergySound = true;
                particle.Play();
            }
            StartCoroutine(dashAtPlayer());
      
         
           wasRaging = true;
        }
        else if (wasRaging && !isRaging) 
           
        {
            CameraMovement.bigbigShake = true;
            GameController.attack3rd = false;
            GameController.cacodeamonUltEffect = false;
            Vector3 add = new Vector3(2f,0,0);
            Instantiate(smoke, transform.position + add, Quaternion.identity);
            GameObject obg = Instantiate(smoke, transform.position - add, Quaternion.identity);
            SpriteRenderer spriteRenderer = obg.GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = true;
            dropSound.Play();
            hasPlayedEnergySound = false;
            particle.Stop();
            wasRaging = false;  
           
        }
          
                
        
}


    IEnumerator dashAtPlayer()
    {
        yield return new WaitForSeconds(1.5f);

        while (Vector3.Distance(transform.position, lastKnownPlayerPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, lastKnownPlayerPosition, 0.5f * Time.deltaTime);
            yield return null;
        }
    

        isRaging = false;
        isRoaming = true;
      

    }

    IEnumerator backToRoaming()
    {
        yield return new WaitForSeconds(2f);

        if (dashCounter >= 3)
        {
            

            int random = Random.Range(0, 3);
            switch (random)
            {
                case 0:
                     isRoaming = false;
                     isAttacking = true;

                     int rand = Random.Range(0, 4);
                     dashCounter = rand;
                     break;
                  
                case 1:
                    isRoaming = false;
                    isAttacking = true;

                    int rand1 = Random.Range(0, 4);
                    dashCounter = rand1;
                    break; 
                  
                case 2:
                    isRaging = true;
                    isRoaming = false;
                    isAttacking = false;
                    isDashing = false;
                    int rand2 = Random.Range(0, 4);
                    dashCounter = rand2;
                    break;
            }

          
        }
        else
        {
            isRoaming = true;
            isAttacking = false;
        }
    }

    private void checkDirection()
    {
        if (player.position.x < transform.position.x && faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = false;

        }
        else if (player.position.x > transform.position.x && !faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = true;

        }
    }
}
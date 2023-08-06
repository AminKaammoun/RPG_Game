using System.Collections;
using UnityEngine;

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

    private float timeBtwDash = 5f;
    private Vector3 lastKnownPlayerPosition;
    private float dashSpeed = 10f;
    private int dashCounter = 0;
    private Animator animator;
    public GameObject projectile;
    private int projectileCounter = 0;

    private float timeBtwShoot = 1f;

    public GameObject right;
    public GameObject left;
    public GameObject projectileStatic;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Debug.Log(dashCounter);
        checkDirection();

        if(faceLeft)
        {
            projectileStatic.transform.position = right.transform.position;
        }
        else
        {
            Vector3 add = new Vector3(2.25f, 0,0);
             projectileStatic.transform.position = left.transform.position - add;
        }
           
        
       


        if (timeBtwDash < 0)
        {
            isDashing = true;
            isRoaming = false;
            timeBtwDash = 5f; // Reset the dash timer
            lastKnownPlayerPosition = player.position; // Store the player's position when starting to dash
        }
        else
        {
            timeBtwDash -= Time.deltaTime;
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
            // Move the boss towards the last known player position during the dash
            Vector3 directionToLastKnownPosition = lastKnownPlayerPosition - transform.position;
            Vector3 normalizedDirectionToLastKnownPosition = directionToLastKnownPosition.normalized;
            transform.position += normalizedDirectionToLastKnownPosition * dashSpeed * Time.deltaTime;

            // If the distance between the current position and the last known position is less than a threshold, end the dash
            if (Vector3.Distance(transform.position, lastKnownPlayerPosition) < 0.1f)
            {
                isDashing = false;
                StartCoroutine(backToRoaming());
                dashCounter++; // Increment the dash counter when a dash is completed
            }
        }

        // If it's the 4th dash, stop moving and play the attack animation
        if (isAttacking)
        {
            isDashing = false;
            isRoaming = false;
            animator.SetBool("attack", true);
            projectileStatic.SetActive(true);
            if(timeBtwShoot < 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                projectileCounter++;

                if (projectileCounter > 2)
                {
                    isAttacking = false;
                    animator.SetBool("attack", false);
                    projectileStatic.SetActive(false);
                    isRoaming = true;
                }
                timeBtwShoot = 1f;
            }
            else
            {
                timeBtwShoot -= Time.deltaTime;
            }
          
        }
    }

    IEnumerator backToRoaming()
    {
        yield return new WaitForSeconds(2f);

        if (dashCounter >= 3)
        {
            isRoaming = false;
            isAttacking = true;
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

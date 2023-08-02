using System.Collections;
using UnityEngine;

public class Cacodaemon : MonoBehaviour
{
    public Transform player;
    public float roamSpeed = 3f;
    public float dashSpeed = 10f;
    public float dashDistance = 3f;
    public float dashCooldown = 2f;

    private bool isDashing = false;
    private Vector3 roamPosition;
    private float dashTimer = 0f;
    private bool faceLeft = true;
    public static float attack;

    private void Start()
    {
        StartCoroutine(RoamAroundPlayer());
    }

    private void Update()
    {
        checkDirection();
        if (!isDashing)
        {
            // Roaming behavior is handled by the coroutine.
        }
        else
        {
            // Dash towards the player
            DashTowardsPlayer();
        }
    }

    private IEnumerator RoamAroundPlayer()
    {
        while (true)
        {
            roamPosition = GetRandomRoamPosition();
            while (Vector3.Distance(transform.position, roamPosition) > 0.1f)
            {
                // Move towards the roaming position
                Vector3 directionToRoamPosition = (roamPosition - transform.position).normalized;
                transform.position += directionToRoamPosition * roamSpeed * Time.deltaTime;
                yield return null;
            }

            // Wait a bit before selecting the next roaming position
            float waitTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(waitTime);
        }
    }

    private Vector3 GetRandomRoamPosition()
    {
        float roamRadius = 5f; // Adjust this radius based on how far you want the enemy to roam from the player.
        Vector2 randomOffset = Random.insideUnitCircle * roamRadius;
        Vector3 targetPosition = player.position + new Vector3(randomOffset.x, 0f, randomOffset.y);
        return targetPosition;
    }

    private void DashTowardsPlayer()
    {
        Vector3 dashDirection = (player.position - transform.position).normalized;
        transform.position += dashDirection * dashSpeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, player.position) <= dashDistance)
        {
            isDashing = false;
            dashTimer = dashCooldown;
        }
    }

    public void StartDash()
    {
        if (dashTimer <= 0f)
        {
            isDashing = true;
            StopCoroutine(RoamAroundPlayer()); // Stop the roaming coroutine when dashing.
        }
    }

    private void FixedUpdate()
    {
        if (dashTimer > 0f)
        {
            dashTimer -= Time.deltaTime;
        }
    }

    void checkDirection()
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

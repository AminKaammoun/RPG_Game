using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricProjectile : MonoBehaviour
{
    private float speed = 15f;
    private Transform player;
    private Vector3 initialPosition; // Added variable to store the initial position of the projectile

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        initialPosition = transform.position; // Store the initial position
        Destroy(this.gameObject, 3f);
    }

    private void Update()
    {
        // Calculate the direction vector from the initial position to the player's position
        Vector3 direction = (player.position - initialPosition).normalized;

        // Move the GameObject in the current direction continuously
        transform.position += direction * speed * Time.deltaTime;
    }
}

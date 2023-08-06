using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricProjectile : MonoBehaviour
{
    private float speed = 15f;
    private Transform player;
    private Vector2 target;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        Destroy(this.gameObject,1f);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target ,speed * Time.deltaTime);
    }

    
} 
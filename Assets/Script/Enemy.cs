using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}


public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public FloatValue maxHealth;
    public string enemyName;
    public float health;
    public int baseAttack;
    public float moveSpeed;
    public Animator animator;
    public Rigidbody2D rb;

    private void Awake()
    {
        health = maxHealth.initialValue;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    
    public void TakeDamage(int damage)
    {
        health -= damage;

    }
}

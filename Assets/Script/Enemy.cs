using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger,
    dead
}


public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public FloatValue maxHealth;
    public string enemyName;
    public float health = 100f;
    public int baseAttack;
    public float moveSpeed;
    public Animator animator;
    public Rigidbody2D rb;
    public static float defence;

    private void Awake()
    {
        health = maxHealth.initialValue;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    public void TakeDamage(float damage)
    {
        health -= damage;
        damageText.num = 0;
    }

    public void Knock(Rigidbody2D rb2d, float knockTime)
    {
        StartCoroutine(KnockCo(rb2d, knockTime));
    }

    private IEnumerator KnockCo(Rigidbody2D rb2d, float KnockTime)
    {
        if (rb2d != null) {
            yield return new WaitForSeconds(KnockTime);
            rb2d.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            rb2d.velocity = Vector2.zero;
        }
    }
}
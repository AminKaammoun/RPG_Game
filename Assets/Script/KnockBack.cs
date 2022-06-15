using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float knockTime;
    [SerializeField] private string otherTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(otherTag))
        {
            Rigidbody2D hit = collision.GetComponent<Rigidbody2D>();
            if (hit != null)
            {
                Vector2 forceDirection = hit.transform.position - transform.position;
                Vector2 force = forceDirection.normalized * thrust;


                if ((collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BringerOfDeath")) || collision.gameObject.CompareTag("log") && collision.isTrigger)
                {
                    CameraMovement.shake = true;
                    hit.velocity = force;
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    collision.GetComponent<Enemy>().Knock(hit, knockTime);
                }
                
                if (collision.gameObject.CompareTag("Player") && collision.isTrigger)
                {
                    CameraMovement.shake = true;
                    hit.transform.Translate(force * 10f * Time.deltaTime);
                    hit.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                    collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);
                }
                

            }
        }

    }


}

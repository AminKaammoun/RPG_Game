using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float knockTime;
    [SerializeField] private string otherTag;
    [SerializeField] private LayerMask dashLayerMask;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(otherTag))
        {
            Rigidbody2D hit = collision.GetComponent<Rigidbody2D>();
            if (hit != null)
            {
                Vector2 forceDirection = hit.transform.position - transform.position;
                Vector3 force = forceDirection.normalized * thrust;


                if ((collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BringerOfDeath") || collision.gameObject.CompareTag("log") || collision.gameObject.CompareTag("treant") || collision.gameObject.CompareTag("crab")) && collision.isTrigger)
                {

                    CameraMovement.shake = true;
                    hit.velocity = force;
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    collision.GetComponent<Enemy>().Knock(hit, knockTime);

                }

                if (collision.gameObject.CompareTag("Player") && collision.isTrigger)
                {
                    CameraMovement.shake = true;
                    if (this.gameObject.tag == "spikeRight")
                    {
                        forceDirection = new Vector2(hit.transform.position.x, hit.transform.position.y - transform.position.y);
                        force = forceDirection.normalized * thrust;
                    }
                    else if (this.gameObject.tag == "spikeLeft")
                    {
                        forceDirection = new Vector2(hit.transform.position.x, hit.transform.position.y - transform.position.y);
                        force = forceDirection.normalized * thrust * -1;
                    }
                    hit.transform.Translate(force * Time.deltaTime * 10f);
                    hit.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                    collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);

                }
                if ((collision.gameObject.CompareTag("babyCyclop") || collision.gameObject.CompareTag("bat")) && collision.isTrigger)
                {
                    CameraMovement.shake = true;

                    hit.transform.Translate(force * Time.deltaTime * 10f);
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    collision.GetComponent<Enemy>().Knock(hit, knockTime);
                }

            }
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float knockTime;
    [SerializeField] private string otherTag;
    //[SerializeField] private LayerMask dashLayerMask;
    private bool knocked = false;
    private Vector3 forceDirection;
    private Vector3 force;
    GameObject player;
    Rigidbody2D rb2D;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
        rb2D = player.GetComponent<Rigidbody2D>();
             
    }


    private void FixedUpdate()
    {
        if (knocked)
        {
             
             Vector3 targetPosition = player.transform.position + forceDirection * 2f;

             RaycastHit2D hit = Physics2D.Raycast(player.transform.position, forceDirection, 2f, PlayerMovements.dashLayerMask); 
             if (hit.collider != null)
             {
                 targetPosition = hit.point;
             }

            rb2D.MovePosition(targetPosition);

            knocked = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(otherTag))
        {
            Rigidbody2D hit = collision.GetComponent<Rigidbody2D>();
            if (hit != null)
            {
                forceDirection = hit.transform.position - transform.position;
                force = forceDirection.normalized * thrust;


                if ((collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BringerOfDeath") || collision.gameObject.CompareTag("shard") || collision.gameObject.CompareTag("golem") || collision.gameObject.CompareTag("log") || collision.gameObject.CompareTag("treant") || collision.gameObject.CompareTag("crab") || collision.gameObject.CompareTag("lightFish") || collision.gameObject.CompareTag("jellyFish")) && collision.isTrigger)
                {

                    CameraMovement.shake = true;
                    hit.velocity = force;
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    collision.GetComponent<Enemy>().Knock(hit, knockTime);

                }

                if (collision.gameObject.CompareTag("Player") && collision.isTrigger)
                {
                    if (!PlayerMovements.in3rdCombo)
                    {
                        CameraMovement.shake = true;
                        if (this.gameObject.tag == "spikeRight")
                        {
                            forceDirection = new Vector3(hit.transform.position.x, hit.transform.position.y - transform.position.y);
                            force = forceDirection.normalized * thrust;
                            hit.transform.Translate(force * Time.deltaTime * 10f);
                            hit.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                            collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);
                        }
                        else if (this.gameObject.tag == "spikeLeft")
                        {
                            forceDirection = new Vector3(hit.transform.position.x, hit.transform.position.y - transform.position.y);
                            force = forceDirection.normalized * thrust * -1;
                            hit.transform.Translate(force * Time.deltaTime * 10f);
                            hit.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                            collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);
                        }
                        else
                        {
                           /* CameraMovement.shake = true;
                            rb2D.velocity = Vector2.zero; // Stop any existing velocity
                            rb2D.AddForce(force, ForceMode2D.Impulse);
                            collision.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                            collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);*/
                            
                            knocked = true;

                        }
                        //hit.transform.Translate(force * Time.deltaTime * 10f);
                        //hit.AddForce(force, ForceMode2D.Impulse);
                       
                    }
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

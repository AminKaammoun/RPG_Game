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
    

    private void FixedUpdate()
    {
        if (knocked)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Vector3 targetPosition = player.transform.position + forceDirection * 3f;
          
            RaycastHit2D hit = Physics2D.Raycast(player.transform.position, forceDirection, 3f, PlayerMovements.dashLayerMask); ;
            if (hit.collider != null)
            {
                targetPosition = hit.point;
            }
           
            Rigidbody2D rb2D = player.GetComponent<Rigidbody2D>();
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


                if ((collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BringerOfDeath") || collision.gameObject.CompareTag("log") || collision.gameObject.CompareTag("treant") || collision.gameObject.CompareTag("crab") || collision.gameObject.CompareTag("lightFish") || collision.gameObject.CompareTag("jellyFish")) && collision.isTrigger)
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
                        }
                        else if (this.gameObject.tag == "spikeLeft")
                        {
                            forceDirection = new Vector3(hit.transform.position.x, hit.transform.position.y - transform.position.y);
                            force = forceDirection.normalized * thrust * -1;
                        }
                        //hit.transform.Translate(force * Time.deltaTime * 10f);
                        //hit.AddForce(force, ForceMode2D.Impulse);
                        knocked = true;
                        hit.GetComponent<PlayerMovements>().currentState = PlayerState.stagger;
                        collision.GetComponent<PlayerMovements>().Knock(hit, knockTime);
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

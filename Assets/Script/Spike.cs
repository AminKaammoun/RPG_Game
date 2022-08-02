using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    public Animator animator;
    private float timeBtwUp;
    private float startTime = 2f;

    public AudioSource SpikeSound;
    
    // Start is called before the first frame update
    void Start()
    {
        timeBtwUp = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwUp <= 0)
        {
            animator.SetBool("trigger", true);
            SpikeSound.Play();
            timeBtwUp = startTime;
            StartCoroutine(backFromUp());
        }
        else
        {
            timeBtwUp -= Time.deltaTime;
        }
    }

    IEnumerator backFromUp()
    {
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("trigger",false);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour
{
    public Animator animator;
    private float timeBtwUp;
    private float startTime = 2f;

    public AudioSource PushSound;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwUp = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwUp <= 0)
        {
            animator.SetBool("trigger", true);
            PushSound.Play();
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
        yield return new WaitForSeconds(1f);
        animator.SetBool("trigger", false);
    }

}

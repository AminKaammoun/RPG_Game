using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class followPlayer : MonoBehaviour
{

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.transform.position;

    }
    void Update()
    {
       
        if (!GameController.ultPressed)
        {
            Destroy(this.gameObject);
        }
    }

  
}

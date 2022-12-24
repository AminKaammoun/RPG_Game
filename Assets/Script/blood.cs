using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood : MonoBehaviour
{
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            target = GameObject.FindGameObjectWithTag("worm").transform;
        }catch(System.NullReferenceException e)
        {
            target = GameObject.FindGameObjectWithTag("lizard").transform;
        }
        Destroy(this.gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public Vector3 target;
    public float speed=2f;
    public SpriteRenderer worm;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(112.9f, 75.77f, 0f); 
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == 101.15f)
        {
            worm.flipX = false;
            target = new Vector3(112.9f, 75.77f, 0f);
        }else if (transform.position.x == 112.9f)
        {
            worm.flipX = true;
            target = new Vector3(101.15f, 75.77f, 0f);
        }
    }
}

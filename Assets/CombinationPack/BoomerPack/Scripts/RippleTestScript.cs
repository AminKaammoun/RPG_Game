using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleTestScript : MonoBehaviour
{
    [Header("Testing Values")]

    [Tooltip("Speed controls the rate at which the ripple happens, magnitude effects How intensly the UV is pulled, and size effects the size of the ring, the smaller, the tighter the ring.")]
    public float 
        speed = 1, 
        magnituted = -.5f, 
        size = .11f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {          
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            //Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            FindObjectOfType<BoomEffect>().ripplemat.SetFloat("TimeStep", 0);
            FindObjectOfType<BoomEffect>().Boom(mousePos,speed, magnituted, size);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If attached to an object, on impact with anything it will create a ripple between them. Works best with similarly sized objects.
        FindObjectOfType<BoomEffect>().Boom((transform.position + collision.transform.position) / 2);

        
    }
}

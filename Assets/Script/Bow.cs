using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    private Rigidbody2D bow;

    public GameObject Hand;
    Vector2 mousePos;
    Vector2 movement;

    public Camera cam;
    private float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        bow = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.FindWithTag("Hand");
        bow.transform.position = Hand.transform.position;
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        bow.MovePosition(bow.position + movement * speed * Time.fixedDeltaTime);
       
        Vector2 lookDir = mousePos - bow.position;
        float angle = Vector2.SignedAngle(Vector2.right, lookDir);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultDirection : MonoBehaviour
{
    Vector2 mousePos;
    public Camera cam;

    private Rigidbody2D dir;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        dir = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Player.position;
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - dir.position;
        float angle = Vector2.SignedAngle(Vector2.up, lookDir);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followRedDragon : MonoBehaviour
{
    private GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("red_dragon");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position;
    }
}


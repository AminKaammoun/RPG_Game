using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    public GameObject arrows;
    public GameObject bow;
    private float TimeBtwSpawn = 0.5f;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (currentTime <= 0 && PlayerMovements.invIsOpen == false)
        {
            if (Input.GetMouseButton(0))
            {

                Instantiate(arrows, bow.transform.position, bow.transform.rotation);
                currentTime = TimeBtwSpawn;
            }

        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}

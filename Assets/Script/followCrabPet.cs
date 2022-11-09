using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCrabPet : MonoBehaviour
{
    private GameObject Target;
    private Vector3 add;
    // Start is called before the first frame update
    void Start()
    {

        Target = GameObject.FindGameObjectWithTag("crab_Pet");
        add = new Vector3(0.05f, -0.25f, 0);

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + add;
    }
}

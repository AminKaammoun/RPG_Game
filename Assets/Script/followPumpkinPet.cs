using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPumpkinPet : MonoBehaviour
{
    private GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("pumpkin_Pet");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardShield : MonoBehaviour
{

    private GameObject lizard;
    // Start is called before the first frame update
    void Start()
    {
        lizard = GameObject.FindGameObjectWithTag("lizard");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lizard.transform.position;
    }
}

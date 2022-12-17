using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEyePet : MonoBehaviour
{
    private GameObject Target;
    Vector3 add;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("eye_Pet");
        add = new Vector3(0f, 0.25f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + add;
    }
}

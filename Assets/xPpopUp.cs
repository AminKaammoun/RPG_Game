using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xPpopUp : MonoBehaviour
{
    private Transform Target;
    Vector3 add = new Vector3(0f, 0.75f, 0f);

    private void Start()
    {
        Target = GameObject.FindWithTag("Player").transform;
        Destroy(this.gameObject, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + add;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followGreenDragon : MonoBehaviour
{
    private GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("greenDragon_Pet");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position;
    }
}

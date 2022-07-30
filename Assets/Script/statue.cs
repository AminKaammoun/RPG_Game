using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statue : MonoBehaviour
{
    private float TimeBtwSpwn;
    private float StartTime;

    public GameObject BabyCyclop;

    public static bool isRaged = false;

    // Start is called before the first frame update
    void Start()
    {
        StartTime = Random.Range(3, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isRaged)
        {
            if (TimeBtwSpwn <= 0)
            {
                Instantiate(BabyCyclop, transform.position, Quaternion.identity);
                StartTime = Random.Range(3, 10);
                TimeBtwSpwn = StartTime;
            }
            else
            {
                TimeBtwSpwn -= Time.deltaTime;
            }
        }
    }
}

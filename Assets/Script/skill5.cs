using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill5 : MonoBehaviour
{
    private float TimeBtwSpawn;
    private float startTime = 0.05f;

    private float maxXpos;
    private float maxYpos;
    private float minXpos;
    private float minYpos;

    private GameObject player;
    public GameObject thunderStrike;

    public static bool spawn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        minXpos = player.transform.position.x - 15f;
        maxXpos = player.transform.position.x + 15f;

        minYpos = player.transform.position.y - 15f;
        maxYpos = player.transform.position.y + 15f;
        if (spawn)
        {
            if (TimeBtwSpawn < 0)
            {
                int xPos = Random.Range((int)minXpos, (int)maxXpos + 1);
                int yPos = Random.Range((int)minYpos, (int)maxYpos + 1);
                Instantiate(thunderStrike, new Vector3((float)xPos, (float)yPos, 0f), Quaternion.identity);
                TimeBtwSpawn = startTime;
            }
            else
            {
                TimeBtwSpawn -= Time.deltaTime;
            }
        }

    }
}


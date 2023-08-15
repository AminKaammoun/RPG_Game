using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatherArea : MonoBehaviour
{
    private bool spawn = true;
    private GameObject[] plantSpawnAreas;
    public GameObject plant;
    public Sprite[] imgs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.hour == 0)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 1)
        {
            spawn = true;
        }
        if (time.hour == 4)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 5)
        {
            spawn = true;
        }
        if (time.hour == 8)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 9)
        {
            spawn = true;
        }
        if (time.hour == 12)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 13)
        {
            spawn = true;
        }
        if (time.hour == 16)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 17)
        {
            spawn = true;
        }
        if (time.hour == 20)
        {
            if (spawn)
            {
                spawnRock();
                spawn = false;
            }
        }
        if (time.hour == 21)
        {
            spawn = true;
        }
    }

    public void spawnRock()
    {

        GameObject[] plants = GameObject.FindGameObjectsWithTag("plant");

        foreach (GameObject plant in plants)
        {
            Destroy(plant);
        }

        /*GameObject[] rocks = GameObject.FindGameObjectsWithTag("rock");

        foreach (GameObject rock in rocks)
        {
            Destroy(rock);
        }*/

        plantSpawnAreas = GameObject.FindGameObjectsWithTag("plantSpawnArea");
       

        foreach (GameObject plantSpawnArea in plantSpawnAreas)
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                   var  pl =  Instantiate(plant, plantSpawnArea.transform.position, Quaternion.identity);
                    SpriteRenderer spriteRenderer = pl.GetComponent<SpriteRenderer>();
                    int rand1 = Random.Range(0, 8);
                    switch (rand1)
                    {
                        case 0:
                            spriteRenderer.sprite = imgs[0];
                        break;
                        case 1:
                            spriteRenderer.sprite = imgs[1];
                            break;
                        case 2:
                            spriteRenderer.sprite = imgs[2];
                            break;
                        case 3:
                            spriteRenderer.sprite = imgs[3];
                            break;
                        case 4:
                            spriteRenderer.sprite = imgs[4];
                            break;
                        case 5:
                            spriteRenderer.sprite = imgs[5];
                            break;
                        case 6:
                            spriteRenderer.sprite = imgs[6];
                            break;
                        case 7:
                            spriteRenderer.sprite = imgs[7];
                            break;
                    }
                  
                break;
            }
        }

      
    }
}

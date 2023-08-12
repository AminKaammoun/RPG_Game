using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    public GameObject bullets;
    public GameObject rifle;
    private float TimeBtwSpawn = 0.25f;
    public float currentTime;

    public AudioSource BowAudio;

    public static bool canShoot = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (currentTime <= 0 && PlayerMovements.invIsOpen == false)
        {
            if (Input.GetMouseButton(0) && canShoot)
            {
                BowAudio.Play();
                Instantiate(bullets, rifle.transform.position, rifle.transform.rotation);
                PlayerMovements.isShootingBullet = true;
                currentTime = TimeBtwSpawn;
            }

        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}

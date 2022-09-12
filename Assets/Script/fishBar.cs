using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishBar : MonoBehaviour
{

    public Slider slider;
    public GameObject FishBar;
    public Animator animator;
    public GameObject bobber;
    public GameObject[] fishs;
    public AudioSource fishcatch;

    public void SetFish(float value)
    {
        slider.value = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value > 0 && slider.value <= 99)
        {
            slider.value -= 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            slider.value += 7.5f;
        }

        if (slider.value >= 99 && fishingArea.instantiateFish)
        {
            fishingArea.instantiateFish = false;
            fishcatch.Stop();
            animator.SetBool("collect", true);
            int rand = Random.Range(0, 100);

            if (rand >= 0 && rand < 50)
            {
                Instantiate(fishs[0], bobber.transform.position, Quaternion.identity);
            }
            else if (rand >= 50 && rand < 70)
            {
                Instantiate(fishs[1], bobber.transform.position, Quaternion.identity);
            }
            else if (rand >= 70 && rand < 85)
            {
                Instantiate(fishs[2], bobber.transform.position, Quaternion.identity);
            }
            else if (rand >= 85 && rand < 95)
            {
                Instantiate(fishs[3], bobber.transform.position, Quaternion.identity);
            }
            else if (rand >= 95 && rand < 100)
            {
                Instantiate(fishs[4], bobber.transform.position, Quaternion.identity);
            }
        }

    }
}

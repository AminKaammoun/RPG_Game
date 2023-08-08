using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;
public class time : MonoBehaviour
{
    public static int min;
    public static int hour;

    private float timeBtwSecs;
    private float startTime = 0.05f;
    public Light2D globalLight;


    public Text currentTime;

    private float intensity;
    private float newIntensity;

    private GameObject[] ForrestLights;
    private GameObject[] VillageLights;
    private GameObject[] LightEffects;
    private GameObject[] BeachDungeonLights;
    public GameObject playerLight;

    private bool changeAudio;
   
    // Start is called before the first frame update
    void Start()
    {
        ForrestLights = GameObject.FindGameObjectsWithTag("Light");
        LightEffects = GameObject.FindGameObjectsWithTag("lightEffect");
        VillageLights = GameObject.FindGameObjectsWithTag("VillageLight");
        BeachDungeonLights = GameObject.FindGameObjectsWithTag("beachDungeonLight");
        min = 0;
        hour = 16;
        intensity = 1;
        newIntensity = 1;
        timeBtwSecs = startTime;
        foreach (GameObject Light in ForrestLights)
        {
            Light.SetActive(false);
        }
        foreach (GameObject LightEffect in LightEffects)
        {
            LightEffect.SetActive(false);
        }
        foreach (GameObject VillageLight in VillageLights)
        {
            VillageLight.SetActive(false);
        }
        foreach (GameObject Light in BeachDungeonLights)
        {
            Light.SetActive(false);
        }
        playerLight.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
           switch (hour)
        {

            case 17:
                globalLight.color = new Color32(255, 238, 215, 255);
                break;

            case 18:
                globalLight.color = new Color32(255, 223, 179, 255);
                break;

            case 19:
                globalLight.color = new Color32(255, 255, 255, 255);

                break;
            case 20:
                playerLight.SetActive(true);

                foreach (GameObject Light in ForrestLights)
                {
                    Light.SetActive(true);

                    Light.GetComponent<Light2D>().intensity = 0.5f;
                }
                foreach (GameObject VillageLight in VillageLights)
                {
                    VillageLight.SetActive(true);

                    VillageLight.GetComponent<Light2D>().intensity = 0.15f;
                }

                foreach (GameObject LightEffect in LightEffects)
                {
                    LightEffect.SetActive(true);
                }
                foreach (GameObject Light in BeachDungeonLights)
                {
                    Light.SetActive(true);
                    Light.GetComponent<Light2D>().intensity = 0.25f;
                }
                break;
            case 22:


                foreach (GameObject Light in ForrestLights)
                {
                    Light.SetActive(true);
                    Light.GetComponent<Light2D>().intensity = 1f;
                }
                foreach (GameObject VillageLight in VillageLights)
                {
                    VillageLight.SetActive(true);

                    VillageLight.GetComponent<Light2D>().intensity = 0.3f;
                }
                foreach (GameObject Light in BeachDungeonLights)
                {
                    Light.SetActive(true);
                    Light.GetComponent<Light2D>().intensity = 0.5f;
                }
                break;
            case 3:
                globalLight.color = new Color32(255, 255, 255, 255);

                break;


            case 4:
                globalLight.color = new Color32(255, 223, 179, 255);
                playerLight.SetActive(false);

                foreach (GameObject Light in ForrestLights)
                {
                    Light.SetActive(true);

                    Light.GetComponent<Light2D>().intensity = 0.5f;
                }
                foreach (GameObject VillageLight in VillageLights)
                {
                    VillageLight.SetActive(true);

                    VillageLight.GetComponent<Light2D>().intensity = 0.15f;
                }
                foreach (GameObject Light in BeachDungeonLights)
                {
                    Light.SetActive(true);
                    Light.GetComponent<Light2D>().intensity = 0.25f;
                }
                break;

            case 5:
                globalLight.color = new Color32(255, 238, 215, 255);

                
                foreach (GameObject LightEffect in LightEffects)
                {
                    LightEffect.SetActive(false);
                }
                break;

            case 7:
                foreach (GameObject Light in ForrestLights)
                {
                    Light.SetActive(false);
                }
               
                foreach (GameObject VillageLight in VillageLights)
                {
                    VillageLight.SetActive(false);
                }
                foreach (GameObject Light in BeachDungeonLights)
                {
                    Light.SetActive(false);
                   
                }
                globalLight.color = new Color32(255, 255, 255, 255);
                break;

        }


        intensity = Mathf.Lerp(intensity, newIntensity, 2f * Time.deltaTime);
        if (timeBtwSecs <= 0)
        {

            if (min == 59)
            {
                min = 0;
                if (hour == 23)
                {
                    hour = 0;
                }
                else
                {
                    hour += 1;
                    if (hour >= 17 && hour <= 22)
                    {

                        newIntensity = intensity - 0.9f / 6;
                        StartCoroutine(getNewIntensity());

                    }
                    else if (hour >= 3 && hour <= 8)
                    {
                        newIntensity = intensity + 0.9f / 6;
                        StartCoroutine(getNewIntensity());
                    }
                }

            }
            else
            {
                min += 1;
            }
            timeBtwSecs = startTime; 
        }

        else
        {
            timeBtwSecs -= Time.deltaTime;
        }
        if (min < 10 && hour >= 10)
        {
            currentTime.text = hour + ":" + "0" + min;
        }
        else if (min >= 10 && hour < 10)
        {
            currentTime.text = "0" + hour + ":" + min;
        }
        else if (hour < 10 && min < 10)
        {
            currentTime.text = "0" + hour + ":" + "0" + min;
        }
        else
        {
            currentTime.text = hour + ":" + min;
        }
        globalLight.intensity = intensity;
   
    
    }
    IEnumerator getNewIntensity()
    {
        yield return new WaitForSeconds(2f);
        intensity = newIntensity;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AgiBar : MonoBehaviour
{
    public Slider slider;


    public void SetAgi(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxAgi(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addAgi(float xp)
    {
        slider.value = slider.value + xp;

    }
}

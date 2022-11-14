using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodBar : MonoBehaviour
{
    public Slider slider;


    public void SetFood(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxFood(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addFood(float xp)
    {
        slider.value = slider.value + xp;

    }
}

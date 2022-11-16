using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpBar : MonoBehaviour
{
    public Slider slider;


    public void SetSp(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxSp(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addSp(float xp)
    {
        slider.value = slider.value + xp;

    }
}

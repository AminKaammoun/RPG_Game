using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtkBar : MonoBehaviour
{
    public Slider slider;


    public void SetAtk(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxAtk(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addAtk(float xp)
    {
        slider.value = slider.value + xp;

    }
}

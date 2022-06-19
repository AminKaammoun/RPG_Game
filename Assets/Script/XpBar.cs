using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class XpBar : MonoBehaviour
{

    public Slider slider;


    public void SetXp(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxXp(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addXP(float xp)
    {
        slider.value = slider.value + xp;

    }
}

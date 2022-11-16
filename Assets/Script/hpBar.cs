using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpBar : MonoBehaviour
{
    public Slider slider;


    public void SetHp(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxHp(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addHp(float xp)
    {
        slider.value = slider.value + xp;

    }
}

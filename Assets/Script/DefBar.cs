using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DefBar : MonoBehaviour
{
    public Slider slider;


    public void SetDef(float xp)
    {
        slider.value = xp;
    }

    public void SetMaxDef(float xp)
    {
        slider.value = xp;
        slider.maxValue = xp;
    }
    public void addDef(float xp)
    {
        slider.value = slider.value + xp;

    }
}

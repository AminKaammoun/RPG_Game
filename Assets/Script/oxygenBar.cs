using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenBar : MonoBehaviour
{
    public Slider slider;
    public void SetOxyValue(float xp)
    {
        slider.value = xp;
    }
} 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ultBar : MonoBehaviour
{
    public Slider slider;
    public void SetUltValue(float xp)
    {
        slider.value = xp;
    }
}

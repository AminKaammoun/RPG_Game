using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{


    public Slider slider;
    
    
   public void SetHealth(float health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(float health)
    {
        slider.value = health;
        slider.maxValue = health;
    }
    public void addHealth(float health)
    {
        slider.value = slider.value + health;

    }
}

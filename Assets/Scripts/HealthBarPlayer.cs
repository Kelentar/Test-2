using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlayer : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health1)
    {
        slider.maxValue = health1;
        slider.value = health1;

        //fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health1)
    {
        slider.value = health1;

        //fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healty_Bar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int healty)
    {
        slider.maxValue = healty;
        slider.value = healty;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int healty)
    {
        slider.value = healty;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}

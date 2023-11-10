using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettingsController : MonoBehaviour
{
    public static event Action<float> ShowSlider1Value;

    private void OnEnable()
    {
        AudioSettings.Slider1Changed += OnSlider1Changed;

    }

    private void OnDisable()
    {
        AudioSettings.Slider1Changed -= OnSlider1Changed;

    }


    private void OnSlider1Changed(float value)
    {
        Debug.Log($"Slider 1 value changed to: {value}");
        ShowSlider1Value?.Invoke(value);
    }

}

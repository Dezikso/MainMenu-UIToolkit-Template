using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioSettings : MenuScreen
{
    public static event Action<float> Slider1Changed;

    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string slider1Name;
    [SerializeField] private string slider1ValueLabelName;

    [Header("Sliders Default Values")]
    [SerializeField] private float slider1DefaultValue;

    private Slider slider1;
    private Label slider1ValueLabel;


    private void OnEnable()
    {
        AudioSettingsController.ShowSlider1Value += OnShowSlider1Value;
    }

    private void OnDisable()
    {
        AudioSettingsController.ShowSlider1Value -= OnShowSlider1Value;
    }


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        slider1 = root.Q<Slider>(slider1Name);
        slider1ValueLabel = root.Q<Label>(slider1ValueLabelName);
    }

    protected override void InitializeButtonValues()
    {
        slider1.value = slider1DefaultValue;
        slider1ValueLabel.text = slider1DefaultValue + "%";
    }

    protected override void RegisterButtonCallbacks()
    {
        slider1?.RegisterValueChangedCallback(ChangeSlider1);
    }


    private void ChangeSlider1(ChangeEvent<float> evt)
    {
        Slider1Changed?.Invoke(evt.newValue);
    }

    private void OnShowSlider1Value(float value)
    {
        slider1ValueLabel.text = value + "%";
    }
}

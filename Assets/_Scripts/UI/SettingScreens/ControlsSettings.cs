using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlsSettings : MenuScreen
{
 public static event Action Remap1ButtonClicked;

    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string remap1ButtonName;

    [Header("Default Values")]
    [SerializeField] private string remap1LabelDefaultValue;
    private Button remap1Button;


    private void OnEnable()
    {
        ControlsSettingsController.ShowRemap1Label += OnShowRemap1Label;
    }

    private void OnDisable()
    {
        ControlsSettingsController.ShowRemap1Label -= OnShowRemap1Label;
    }


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        remap1Button = root.Q<Button>(remap1ButtonName);
    }

    protected override void InitializeButtonValues()
    {
        remap1Button.text = remap1LabelDefaultValue;
    }

    protected override void RegisterButtonCallbacks()
    {
        remap1Button?.RegisterCallback<ClickEvent>(HandleRemap1Button);
    }


    private void HandleRemap1Button(ClickEvent evt)
    {
        Remap1ButtonClicked?.Invoke();
    }

    private void OnShowRemap1Label(string value)
    {
        remap1Button.text = value;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameSettings : MenuScreen
{
 public static event Action<bool> Toggle1Changed;

    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string toggle1Name;

    [Header("Toggles Default Values")]
    [SerializeField] private bool toggle1DefaultValue;

    private Toggle toggle1;


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        toggle1 = root.Q<Toggle>(toggle1Name);
    }

    protected override void InitializeButtonValues()
    {
        toggle1.value = toggle1DefaultValue;
    }

    protected override void RegisterButtonCallbacks()
    {
        toggle1?.RegisterValueChangedCallback(ChangeToggle1);
    }


    private void ChangeToggle1(ChangeEvent<bool> evt)
    {
        Toggle1Changed?.Invoke(evt.newValue);
    }
}

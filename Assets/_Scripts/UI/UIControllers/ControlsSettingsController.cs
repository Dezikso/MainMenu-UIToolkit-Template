using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsSettingsController : MonoBehaviour
{
    public static event Action<string> ShowRemap1Label;

    private string exampleKeyRemapName = "Key 2";

    private void OnEnable()
    {
        ControlsSettings.Remap1ButtonClicked += OnRemap1ButtonClicked;
    }

    private void OnDisable()
    {
        ControlsSettings.Remap1ButtonClicked -= OnRemap1ButtonClicked;
    }


    private void OnRemap1ButtonClicked()
    {
        Debug.Log($"Remap button 1 clicked");
        ShowRemap1Label?.Invoke(exampleKeyRemapName);
    }

}

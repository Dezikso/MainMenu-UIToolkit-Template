using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSettingsController : MonoBehaviour
{
    private void OnEnable()
    {
        VideoSettings.Dropdown1Changed += OnDropdown1Changed;
        VideoSettings.Dropdown2Changed += OnDropdown2Changed;
        VideoSettings.Dropdown3Changed += OnDropdown3Changed;
    }

    private void OnDisable()
    {
        VideoSettings.Dropdown1Changed -= OnDropdown1Changed;
        VideoSettings.Dropdown2Changed -= OnDropdown2Changed;
        VideoSettings.Dropdown3Changed -= OnDropdown3Changed;
    }


    private void OnDropdown1Changed(string value)
    {
        Debug.Log($"Dropdown 1 value changed to: {value}");
    }

    private void OnDropdown2Changed(string value)
    {
        Debug.Log($"Dropdown 2 value changed to: {value}");
    }

    private void OnDropdown3Changed(string value)
    {
        Debug.Log($"Dropdown 3 value changed to: {value}");
    }

}

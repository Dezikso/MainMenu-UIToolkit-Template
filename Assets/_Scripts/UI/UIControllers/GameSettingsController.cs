using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingsController : MonoBehaviour
{
    private void OnEnable()
    {
        GameSettings.Toggle1Changed += OnToggle1Changed;
    }

    private void OnDisable()
    {
        GameSettings.Toggle1Changed -= OnToggle1Changed;
    }


    private void OnToggle1Changed(bool value)
    {
        Debug.Log($"Toggle 1 value changed to: {value}");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsBar : MenuScreen
{
    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string gameSettingsButtonName;
    [SerializeField] private string audioSettingsButtonName;
    [SerializeField] private string videoSettingsButtonName;
    [SerializeField] private string controlsSettingsButtonName;

    private Button gameSettingsButton;
    private Button audioSettingsButton;
    private Button videoSettingsButton;
    private Button controlsSettingsButton;


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        gameSettingsButton = root.Q<Button>(gameSettingsButtonName);
        audioSettingsButton = root.Q<Button>(audioSettingsButtonName);
        videoSettingsButton = root.Q<Button>(videoSettingsButtonName);
        controlsSettingsButton = root.Q<Button>(controlsSettingsButtonName);
    }

    protected override void RegisterButtonCallbacks()
    {
        gameSettingsButton?.RegisterCallback<ClickEvent>(ShowGameSettings);
        audioSettingsButton?.RegisterCallback<ClickEvent>(ShowAudioSettings);
        videoSettingsButton?.RegisterCallback<ClickEvent>(ShowVideoSettings);
        controlsSettingsButton?.RegisterCallback<ClickEvent>(ShowControlsSettings);
    }

    private void ShowGameSettings(ClickEvent evt)
    {
        mainMenuUIManager?.ShowGameSettings();
    }
    private void ShowAudioSettings(ClickEvent evt)
    {
        mainMenuUIManager?.ShowAudioSettings();
    }
    private void ShowVideoSettings(ClickEvent evt)
    {
        mainMenuUIManager?.ShowVideoSettings();
    }
    private void ShowControlsSettings(ClickEvent evt)
    {
        mainMenuUIManager?.ShowControlsSettings();
    }
}

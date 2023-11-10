using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuBar : MenuScreen
{
    public static event Action StartButtonClicked;
    public static event Action QuitButtonClicked;

    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string startMenuButtonName;
    [SerializeField] private string settingsMenuButtonName;
    [SerializeField] private string creditsMenuButtonName;
    [SerializeField] private string quitMenuButtonName;

    private Button startMenuButton;
    private Button settingsMenuButton;
    private Button creditsMenuButton;
    private Button quitMenuButton;


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        startMenuButton = root.Q<Button>(startMenuButtonName);
        settingsMenuButton = root.Q<Button>(settingsMenuButtonName);
        creditsMenuButton = root.Q<Button>(creditsMenuButtonName);
        quitMenuButton = root.Q<Button>(quitMenuButtonName);
    }

    protected override void RegisterButtonCallbacks()
    {
        startMenuButton?.RegisterCallback<ClickEvent>(HandleStartButton);
        settingsMenuButton?.RegisterCallback<ClickEvent>(HandleSettingsButton);
        creditsMenuButton?.RegisterCallback<ClickEvent>(HandleCreditsButton);
        quitMenuButton?.RegisterCallback<ClickEvent>(HandleQuitButton);
    }

    private void HandleStartButton(ClickEvent evt)
    {
        StartButtonClicked?.Invoke();
    }

    private void HandleSettingsButton(ClickEvent evt)
    {
        mainMenuUIManager?.ShowSettingsBar();
    }

    private void HandleCreditsButton(ClickEvent evt)
    {
        mainMenuUIManager?.ShowCreditsBar();
    }

    private void HandleQuitButton(ClickEvent evt)
    {
        QuitButtonClicked?.Invoke();
    }

}

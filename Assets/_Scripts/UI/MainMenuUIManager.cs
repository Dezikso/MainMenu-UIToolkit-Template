using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MainMenuUIManager : MonoBehaviour
{
    [Header("Settings Screens")]
    [SerializeField] private GameSettings gameSettings;
    [SerializeField] private AudioSettings audioSettings;
    [SerializeField] private VideoSettings videoSettings;
    [SerializeField] private ControlsSettings controlsSettings;

    [Header("Menu Toolbars")]
    [SerializeField] private SettingsBar settingsBar;
    [SerializeField] private CreditsBar creditsBar;

    private List<MenuScreen> settingsScreens = new List<MenuScreen>();
    private List<MenuScreen> menuToolbars = new List<MenuScreen>();

    private UIDocument mainMenuDocument;
    public UIDocument MainMenuDocument { get => mainMenuDocument; }


    private void OnEnable()
    {
        mainMenuDocument = GetComponent<UIDocument>();
        SetupMenuToolbar();
        SetupSettingsScreens();
    }

    private void SetupSettingsScreens()
    {
        if (gameSettings != null)
            settingsScreens.Add(gameSettings);

        if (audioSettings != null)
            settingsScreens.Add(audioSettings);

        if (videoSettings != null)
            settingsScreens.Add(videoSettings);

        if (controlsSettings != null)
            settingsScreens.Add(controlsSettings);

    }

    private void SetupMenuToolbar()
    {
        if (settingsBar != null)
            menuToolbars.Add(settingsBar);
        if (creditsBar != null)
            menuToolbars.Add(creditsBar);
    }

    private void ShowSettingsScreen(MenuScreen menuScreen)
    {
        foreach (MenuScreen screen in settingsScreens)
        {
            if (screen == menuScreen)
            {
                screen.ShowScreen();
            }
            else
            {
                screen.HideScreen();
            }
        }
    }

    private void ShowMenuToolbar(MenuScreen menuScreen)
    {
        foreach (MenuScreen screen in menuToolbars)
        {
            if (screen == menuScreen)
            {
                if (!screen.IsVisible())
                {
                    screen.ShowScreen();
                }
                else
                {
                  screen.HideScreen();  
                }
            }
            else
            {
                screen.HideScreen();
            }
        }
    }

    public void ShowGameSettings()
    {
        ShowSettingsScreen(gameSettings);
    }

    public void ShowAudioSettings()
    {
        ShowSettingsScreen(audioSettings);
    }

    public void ShowVideoSettings()
    {
        ShowSettingsScreen(videoSettings);
    }

    public void ShowControlsSettings()
    {
        ShowSettingsScreen(controlsSettings);
    }

    public void ShowSettingsBar()
    {
        ShowMenuToolbar(settingsBar);
    }
    public void ShowCreditsBar()
    {
        ShowMenuToolbar(creditsBar);
    }


}

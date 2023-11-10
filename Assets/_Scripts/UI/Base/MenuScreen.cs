using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


// This is a base class for all the panels displayed within the Main Menu
// It has to be attached to a child of an object holding MainMenuUIManager and UIDocument 
// e. g. MenuBar, GameSettingsScreen, AudioSettingsScreen

public abstract class MenuScreen : MonoBehaviour
{
    [Tooltip("String name of this screen in the UXML document")]
    [SerializeField] protected string screenName;

    [Tooltip("UI Management")]
    [SerializeField] protected MainMenuUIManager mainMenuUIManager;
    [SerializeField] protected UIDocument menuDocument;

    protected VisualElement root;
    protected VisualElement screen;


    private void Awake()
    {
        //Auto reference mainMenuUIManager and UIDocument
        if (mainMenuUIManager == null)
        {
            mainMenuUIManager = GetComponentInParent<MainMenuUIManager>();
            
            if (menuDocument == null)   
            {
                menuDocument = mainMenuUIManager.MainMenuDocument;
            }
        }
        
        SetVisualElement();
        InitializeButtonValues();
        RegisterButtonCallbacks();
    }


    private void ShowVisualElement(VisualElement visualElement, bool state)
    {
        if (visualElement == null)
            return;

        visualElement.style.display = (state) ? DisplayStyle.Flex : DisplayStyle.None;
    }

    protected virtual void SetVisualElement()
    {
        if (menuDocument != null)
            root = menuDocument.rootVisualElement;
        
        screen = GetVisualElement(screenName);
    }

    protected virtual void InitializeButtonValues()
    {

    }

    protected virtual void RegisterButtonCallbacks()
    {

    }

    protected VisualElement GetVisualElement(string elementName)
    {
        if (string.IsNullOrEmpty(elementName) || root == null)
            return null;

        return root.Q(elementName);
    }

    public bool IsVisible()
    {
        if (screen == null)
            return false;

        return screen.style.display == DisplayStyle.Flex;
    }

    public void ShowScreen()
    {
        ShowVisualElement(screen, true);
    }

    public void HideScreen()
    {
        if (IsVisible())
        {
            ShowVisualElement(screen, false);
        }
    }

}

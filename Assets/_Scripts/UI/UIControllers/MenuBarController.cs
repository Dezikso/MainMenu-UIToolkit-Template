using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuBarController : MonoBehaviour
{

    private void OnEnable()
    {
        MenuBar.StartButtonClicked += OnApplicationStart;
        MenuBar.QuitButtonClicked += OnApplicationQuit;
    }

    private void OnDisable()
    {
        MenuBar.StartButtonClicked -= OnApplicationStart;
        MenuBar.QuitButtonClicked -= OnApplicationQuit;       
    }


    private void OnApplicationStart()
    {
        //Implement Next scene loading here
        Debug.Log("Application Starting");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("You quit the Application");

        Application.Quit();
    }
}

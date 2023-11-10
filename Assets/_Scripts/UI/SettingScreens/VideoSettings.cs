using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VideoSettings : MenuScreen
{
    public static event Action<string> Dropdown1Changed;
    public static event Action<string> Dropdown2Changed;
    public static event Action<string> Dropdown3Changed;

    [Tooltip("String names of UI Elements in UXML document")]
    [Header("UI Elements names")]
    [SerializeField] private string dropdownField1Name;
    [SerializeField] private string dropdownField2Name;
    [SerializeField] private string dropdownField3Name;

    [Header("Dropdown Field Choices")]
    [SerializeField] private List<string> dropdownField1Choices;
    [SerializeField] private List<string> dropdownField2Choices;
    [SerializeField] private List<string> dropdownField3Choices;

    private DropdownField dropdownField1;
    private DropdownField dropdownField2;
    private DropdownField dropdownField3;


    protected override void SetVisualElement()
    {
        base.SetVisualElement();

        dropdownField1 = root.Q<DropdownField>(dropdownField1Name);
        dropdownField2 = root.Q<DropdownField>(dropdownField2Name);
        dropdownField3 = root.Q<DropdownField>(dropdownField3Name);
    }

    protected override void InitializeButtonValues()
    {
        dropdownField1.choices = dropdownField1Choices;
        dropdownField1.value = dropdownField1Choices[0];

        dropdownField2.choices = dropdownField2Choices;
        dropdownField2.value = dropdownField2Choices[0];

        dropdownField3.choices = dropdownField3Choices;
        dropdownField3.value = dropdownField3Choices[0];
    }

    protected override void RegisterButtonCallbacks()
    {
        dropdownField1?.RegisterValueChangedCallback(ChangeDropdownField1);
        dropdownField2?.RegisterValueChangedCallback(ChangeDropdownField2);
        dropdownField3?.RegisterValueChangedCallback(ChangeDropdownField3);
    }


    private void ChangeDropdownField1(ChangeEvent<string> evt)
    {
        Dropdown1Changed?.Invoke(evt.newValue);
    }

    private void ChangeDropdownField2(ChangeEvent<string> evt)
    {
        Dropdown2Changed?.Invoke(evt.newValue);
    }

    private void ChangeDropdownField3(ChangeEvent<string> evt)
    {
        Dropdown3Changed?.Invoke(evt.newValue);
    }


}

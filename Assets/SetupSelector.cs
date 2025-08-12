using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;

public class SetupSelector : MonoBehaviour
{
    void Awake()
    {
        TMP_Dropdown napalmSelectorDropdown = GetComponent<TMP_Dropdown>();

        Debug.Log(napalmSelectorDropdown);
        Debug.Log(napalmSelectorDropdown.options);

        List<string> napalmNamesList = Enum.GetNames(typeof(loaded.NapalmTypes)).ToList();
        napalmSelectorDropdown.ClearOptions();
        napalmSelectorDropdown.AddOptions(napalmNamesList);

        loaded.napalmType = (loaded.NapalmTypes)napalmSelectorDropdown.value;
    }
}

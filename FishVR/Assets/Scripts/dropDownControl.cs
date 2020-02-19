using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dropDownControl : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TMP_Text selectedStim;
    List<string> names = new List<string>() { "Select Stimlulus", "OMR", "Random Dots" };
    // Start is called before the first frame update
    void Start()
    {
        PopulateList();
    }
    void PopulateList()
    {
        dropdown.AddOptions(names);
    }
    
    public void Dropdown_IndexChanged(int index)
    {
        selectedStim.text = "Selected stimulus: " + names[index];
    }
}

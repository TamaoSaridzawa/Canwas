using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownToText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Dropdown _dropDown;

    public void DropDownText(int number)
    {
        _text.text = _dropDown.options[number].text;
    }
}

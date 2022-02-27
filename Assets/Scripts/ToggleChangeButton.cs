using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleChangeButton : MonoBehaviour
{
    [SerializeField] private GameObject _button;

    public void TogleChangeButton(bool state)
    {
        _button.SetActive(state);
    }
}

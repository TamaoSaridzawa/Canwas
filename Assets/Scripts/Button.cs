using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _text;
    
    public void OnButtonClick()
    {
        Destroy(_text);
    }
    
}

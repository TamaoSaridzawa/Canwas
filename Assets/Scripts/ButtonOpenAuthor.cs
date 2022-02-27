using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpenAuthor : MonoBehaviour
{
    [SerializeField] CanvasGroup _authorScreen;

   public void OpenAuthor()
    {
        _authorScreen.alpha = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloseAuthor : MonoBehaviour
{
    [SerializeField] private CanvasGroup _closeAuthor;

    public void CloseAuthor()
    {
        _closeAuthor.alpha = 0;
    }
}

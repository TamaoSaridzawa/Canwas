using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonExit : MonoBehaviour
{
    //[SerializeField] private Transform _bunnonStart;
    //[SerializeField] private Transform _bunnonAuthor;
    //[SerializeField] private Transform _bunnonExit;
    //[SerializeField] private float _speed;
    //[SerializeField] private Transform _targetPosition;

    [SerializeField] private Animator _animator;
    //private Transform transformn;

    public void HideButton()
    {
        _animator.enabled = true;
        _animator.SetTrigger("Exit");
        //StartCoroutine(Move());
    }

    //private IEnumerator Move()
    //{
    //    while (true)
    //    {
    //        _bunnonStart.position = Vector2.MoveTowards(_bunnonStart.transform.position, _targetPosition.transform.position, _speed * Time.deltaTime);
    //        _bunnonAuthor.position = Vector2.MoveTowards(_bunnonAuthor.transform.position, _targetPosition.transform.position, _speed * Time.deltaTime);
    //        _bunnonExit.position = Vector2.MoveTowards(_bunnonExit.transform.position, _targetPosition.transform.position, _speed * Time.deltaTime);
    //        //_bunnonStart.transform.position = transformn.position;
    //        yield return null;
    //    }
    //}
}

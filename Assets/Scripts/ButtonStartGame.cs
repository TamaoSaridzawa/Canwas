using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;
    //private Transform _startScale;
    private Button _button;
    //private void Start()
    //{
    //    _startScale = transform;
    //}
    private void Start()
    {
        _button = GetComponent<Button>();
    }
    //private void Update()
    //{

    //    transform.localScale = Vector2.MoveTowards(transform.localScale, new Vector2(500, 100), 5f);
    //}

    public void EnableAnimation()
    {
        //transform.localScale = Vector2.MoveTowards(transform.localScale, new Vector2(500, 100), 5f);
        _particleSystem.Play();
    }
}

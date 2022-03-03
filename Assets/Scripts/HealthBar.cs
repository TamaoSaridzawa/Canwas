using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _speed = 5f;
    private Coroutine _changeJob = null;

    public void ChangeHealth()
    {
        if (_changeJob != null)
        {
            StopCoroutine(_changeJob);
        }

        StartChange();
    }

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _player.Health;
    }

    private void OnEnable()
    {
        _player.ChangeHealth += ChangeHealth;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= ChangeHealth;
    }

    private void StartChange()
    {
        _changeJob = StartCoroutine(Change());
    }

    private IEnumerator Change()
    {
        while (_slider.value != _player.Health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, _speed * Time.deltaTime);

            yield return null;
        }
    }
}

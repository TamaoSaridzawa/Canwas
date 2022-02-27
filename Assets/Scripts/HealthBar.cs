using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _step = 10;
    private float _targetValue;
    private float _speed = 5f;

    private void Start()
    {
        _targetValue = _slider.value;
    }

    public void HealHealth()
    {
        StartCoroutine(Heal());
    }

    public void DealDamage()
    {
        StartCoroutine(Damage());
    }

    private IEnumerator Heal()
    {
        _targetValue += _step;

        while (_slider.value < _targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed * Time.deltaTime);
            yield return null;
        }
    }

    private IEnumerator Damage()
    {
        _targetValue -= _step;

        while (_slider.value > _targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed * Time.deltaTime);
            yield return null;
        }
    }
}

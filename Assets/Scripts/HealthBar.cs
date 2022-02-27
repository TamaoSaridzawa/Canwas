using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _speed = 5f;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void ChangeHealth()
    {
        StartCoroutine(Change());
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

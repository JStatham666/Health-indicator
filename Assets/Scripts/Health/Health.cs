using System;
using UnityEngine;

public class Health
{
    private float _maxValue = 100f;
    private float _minValue = 1f;
    private float _currentValue = 50;

    public event Action ValueChanged;

    public float CurrentValue => _currentValue;
    public float MaxValue => _maxValue;

    public void TakeDamage(float damage)
    {
        _currentValue -= damage;

        if (_currentValue <= 0)
        {
            _currentValue = 0;
        }

        ValueChanged?.Invoke();
    }

    public bool TryAddValue(float recoverValue)
    {
        if (_currentValue == _maxValue)
            return false;

        _currentValue = Mathf.Clamp(_currentValue + recoverValue, _minValue, _maxValue);
        ValueChanged?.Invoke();
        return true;      
    }
}
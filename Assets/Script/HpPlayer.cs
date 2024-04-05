using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpPlayer : MonoBehaviour
{
    [SerializeField] private float _hp;
    [SerializeField] private Slider _hpBar;
    [SerializeField] private Image _reloadScen;

     void OnEnable()
    {
       _hpBar.value = _hp;
    }
    public void TakeDamage(float damage)
    {
        _hp -= damage;
        _hpBar.value = _hp;
        if(_hp <= 0)
        {
            _reloadScen.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}

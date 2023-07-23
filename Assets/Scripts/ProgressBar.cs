using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;

public class ProgressBarObject : MonoBehaviour
{
    private IHpStats _hpStats;
    private Transform _bar;

    public void Bind(IHpStats hpStats)
    {
        _bar = transform.Find("ProgressContainer");
        _hpStats = hpStats;
        hpStats.OnHealthChanged += OnHealthChanged;
    }

    private void OnHealthChanged(int currentHp)
    {
        _bar.localScale = new Vector3(_hpStats.HpInPercents, 1);
    }
}

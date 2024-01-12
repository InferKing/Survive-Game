using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Damage", menuName = "SO/Damage")]
public class DamageInfo : ScriptableObject
{
    [SerializeField, Range(0, 1000)] private float _damage;
    [SerializeField, Range(0, 1)] private float _spread;
    public float Damage { get { return _damage; } }
    public float Spread { get { return _spread; } }
}

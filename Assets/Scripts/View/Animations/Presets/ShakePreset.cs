using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Source/Camera/Shake Preset", fileName = "Shake Preset")]
public class ShakePreset : ScriptableObject
{
    [SerializeField] private ShakePositionRotationSettings _shakeSettings;
    public ShakePositionRotationSettings ShakeSettings { get { return _shakeSettings; } }
}

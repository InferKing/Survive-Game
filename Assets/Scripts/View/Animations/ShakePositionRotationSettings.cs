using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ShakePositionRotationSettings
{
    [SerializeField] private ShakeAnimationPreset _rotationShake;
    [SerializeField] private ShakeAnimationPreset _positionShake;
    public ShakeAnimationPreset RotationShake { get { return _rotationShake; } }
    public ShakeAnimationPreset PositionShake { get { return _positionShake; } }
}

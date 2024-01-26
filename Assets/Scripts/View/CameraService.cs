using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraService : MonoBehaviour, IService
{
    [SerializeField] private Camera _camera, _cutScene;
    public Camera Camera { get { return _camera; } }

    public void ShakeCamera(ShakePreset preset)
    {
        ShakeCamera(preset.ShakeSettings.RotationShake, preset.ShakeSettings.PositionShake);
    }
    public void ShakeCamera(ShakeAnimationPreset rotationPreset, ShakeAnimationPreset positionPreset)
    {
        if (rotationPreset.isOn)
        {
            _camera.transform.ShakeRotationAnimation(rotationPreset);
        }
        if (positionPreset.isOn)
        {
            _camera.transform.ShakePositionAnimation(positionPreset);
        }
    }
}

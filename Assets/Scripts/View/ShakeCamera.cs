using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShakeCamera : MonoBehaviour, IInitializable, IWeaponAttackReaction
{
    private CameraService _cameraService;

    public void Initialize()
    {
        _cameraService = ServiceLocator.Instance.Get<CameraService>();
    }

    public void ReactOnPrimaryAttack(SemiAutoWeapon weapon)
    {
        _cameraService.ShakeCamera(weapon.ShakePreset);
    }
}

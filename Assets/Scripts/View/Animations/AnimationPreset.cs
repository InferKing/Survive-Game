using DG.Tweening;
using System;

[Serializable]
public class AnimationPreset
{
    public bool isOn = true;
    public float duration = 1f;
    public Ease ease = DOTween.defaultEaseType;
}
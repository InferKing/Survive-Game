using System.Collections;
using UnityEngine;

public class SemiAutoWeapon : MonoBehaviour, IWeapon
{
    private int _curClip;
    private bool _canFire = true;
    private WaitForSeconds _sleep;
    [SerializeField] protected DamageInfo _damageInfo;
    [SerializeField] protected WeaponInfo _weaponInfo;
    [SerializeField] private ShakePreset _shakePreset;
    private void Start()
    {
        _sleep = new WaitForSeconds(1/_weaponInfo.RateOfFire);
        _curClip = _weaponInfo.MaxClip;
    }
    public bool TryFire()
    {
        if (_canFire)
        {
            //RaycastHit hit;
            // if (Physics.Raycast(Camera.main.Sc))
            StartCoroutine(DelayFire());
            return true;
        }
        return _canFire;
    }
    public ShakePreset ShakePreset { get { return _shakePreset; } }
    private IEnumerator DelayFire()
    {
        _canFire = false;
        yield return _sleep;
        _canFire = true;
    }
}

using System.Collections;
using UnityEngine;

public class SemiAutoWeapon : MonoBehaviour, IWeapon
{
    private bool _canFire = true;
    private WaitForSeconds _sleep;
    [SerializeField] protected DamageInfo _damageInfo;
    [SerializeField] protected WeaponInfo _weaponInfo;
    private void Start()
    {
        _sleep = new WaitForSeconds(1/_weaponInfo.RateOfFire);
    }
    public bool TryFire()
    {
        if (_canFire)
        {
            StartCoroutine(DelayFire());
            return true;
        }
        return _canFire;
    }
    private IEnumerator DelayFire()
    {
        _canFire = false;
        yield return _sleep;
        _canFire = true;
    }
}

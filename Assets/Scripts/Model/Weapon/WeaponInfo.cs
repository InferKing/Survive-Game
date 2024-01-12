using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "SO/Weapon")]
public class WeaponInfo : ScriptableObject
{

    [SerializeField] private int _maxClip;
    [SerializeField] private float _rateOfFire, _maxDistance;
    [SerializeField] private bool _isAutomatic;
    [SerializeField] private GameObject _weapon;
    [SerializeField] private Vector3 _relativePosition = new(0.277f, -0.239f, 0.37f);
    [SerializeField] private DamageInfo _damageInfo;
    public DamageInfo DamageInfo { get { return _damageInfo; } }
    public Vector3 RelativePosition { get { return _relativePosition; } }
    public GameObject Weapon { get { return _weapon; } }
    public int MaxClip { get { return _maxClip; } }
    public float RateOfFire { get { return _rateOfFire; } }
    public float MaxDistance { get { return _maxDistance; } }
    public bool IsAutomatic { get { return _isAutomatic; } }
}

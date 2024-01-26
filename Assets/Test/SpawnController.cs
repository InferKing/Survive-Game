using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject m_SpawnGameObject, pos;
    private void Start()
    {
        StartCoroutine(Delay());
        
    }
    private IEnumerator Delay()
    {
        for (int i = -40; i < 40; i++)
        {
            for (int j = -10; j < 10; j++)
            {
                Vector3 tpos = transform.position;
                tpos.z = i;
                tpos.x += j;
                GameObject z = Instantiate(m_SpawnGameObject);
                z.transform.parent = transform;
                z.transform.position = tpos;
                ZombieBehaviour r = z.GetComponent<ZombieBehaviour>();
                r.position = pos;
                r.Spawn();
            }
            yield return null;
        }
    }
}

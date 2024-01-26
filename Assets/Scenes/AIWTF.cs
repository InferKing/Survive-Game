using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWTF : MonoBehaviour
{
    [SerializeField] private GameObject m_gameObject;
    [SerializeField] private NavMeshAgent agent;
    private void Update()
    {
        agent.SetDestination(m_gameObject.transform.position);
    }
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityHFSM;

[RequireComponent(typeof(NavMeshAgent))]
public class ZombieBehaviour : MonoBehaviour
{
    private StateMachine<UnitState> _fsm;
    [SerializeField] private NavMeshAgent _agent;
    public GameObject position;
    [SerializeField] private Animator _animator;
    private void Start()
    {
        //_fsm = new StateMachine<UnitState>();

        //_fsm.AddState(UnitState.Idle, onLogic: state => Debug.Log(state.name));
        //_fsm.AddState(UnitState.Walk, onLogic: state => Debug.Log(state.name));
        //_fsm.AddState(UnitState.Attack, onLogic: state => Debug.Log(state.name));
        //_fsm.AddState(UnitState.Death, onLogic: state => Debug.Log(state.name));

        //_fsm.AddTwoWayTransition(UnitState.Idle, UnitState.Walk, 
        //    transition => )
    }

    private void Update()
    {
        _agent.SetDestination(position.transform.position);
    }
    public void Spawn()
    {
        _agent.SetDestination(position.transform.position);
    }
}

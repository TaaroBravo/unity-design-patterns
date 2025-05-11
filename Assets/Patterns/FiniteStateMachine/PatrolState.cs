using Patterns.FiniteStateMachine;
using UnityEngine;

public class PatrolState : State<SimpleAI>
{
    private bool goingToB;

    public override void Enter()
    {
        Debug.Log("Entering Patrol");
        goingToB = false;
        _owner.currentDestination = _owner.pointA;
    }

    public override void Update()
    {
        if (_owner.IsTargetClose())
        {
            _stateMachine.SetState<ChaseState>();
            return;
        }

        _owner.MoveTowards(_owner.currentDestination.position);

        if (Vector3.Distance(_owner.transform.position, _owner.currentDestination.position) < 0.1f)
        {
            goingToB = !goingToB;
            _owner.currentDestination = goingToB ? _owner.pointB : _owner.pointA;
        }
    }

    public override void LateUpdate() { }

    public override void Exit()
    {
        Debug.Log("Exiting Patrol");
    }
}
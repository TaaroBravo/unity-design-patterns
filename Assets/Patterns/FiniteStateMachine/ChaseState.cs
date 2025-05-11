using Patterns.FiniteStateMachine;
using UnityEngine;

public class ChaseState : State<SimpleAI>
{
    public override void Enter()
    {
        Debug.Log("Entering Chase");
    }

    public override void Update()
    {
        if (!_owner.IsTargetClose())
        {
            _stateMachine.SetState<IdleState>();
            return;
        }

        _owner.MoveTowards(_owner.target.position);
    }

    public override void LateUpdate() { }

    public override void Exit()
    {
        Debug.Log("Exiting Chase");
    }
}
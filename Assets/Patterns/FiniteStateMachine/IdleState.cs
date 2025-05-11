using Patterns.FiniteStateMachine;
using UnityEngine;

public class IdleState : State<SimpleAI>
{
    private float _timer;

    public override void Enter()
    {
        Debug.Log("Entering Idle");
        _timer = 2f;
    }

    public override void Update()
    {
        _timer -= Time.deltaTime;
        if (_owner.IsTargetClose())
        {
            _stateMachine.SetState<ChaseState>();
        }
        else if (_timer <= 0f)
        {
            _stateMachine.SetState<PatrolState>();
        }
    }

    public override void LateUpdate() { }

    public override void Exit()
    {
        Debug.Log("Exiting Idle");
    }
}
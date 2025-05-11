using Patterns.FiniteStateMachine;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    private FiniteStateMachine<SimpleAI> _fsm;

    public Transform pointA;
    public Transform pointB;
    public Transform target;

    [HideInInspector] public Transform currentDestination;

    public float speed = 2f;
    public float chaseRange = 5f;

    private void Awake()
    {
        _fsm = new FiniteStateMachine<SimpleAI>(this);
        _fsm.AddState<IdleState>();
        _fsm.AddState<PatrolState>();
        _fsm.AddState<ChaseState>();
        _fsm.SetState<IdleState>();
    }

    private void Update()
    {
        _fsm.Update();
    }

    private void LateUpdate()
    {
        _fsm.LateUpdate();
    }

    public void MoveTowards(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public bool IsTargetClose()
    {
        return Vector3.Distance(transform.position, target.position) <= chaseRange;
    }
}
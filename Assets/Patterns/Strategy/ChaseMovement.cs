using UnityEngine;

namespace Patterns.Strategy
{
    public class ChaseMovement : IMovementStrategy
    {
        private Transform _target;
        private float _speed = 3f;

        public ChaseMovement(Transform target)
        {
            _target = target;
        }

        public void Move(Transform transform)
        {
            Vector3 dir = (_target.position - transform.position).normalized;
            transform.Translate(dir * _speed * Time.deltaTime);
        }
    }
}
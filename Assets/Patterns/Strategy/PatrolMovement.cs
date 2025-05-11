using UnityEngine;

namespace Patterns.Strategy
{
    public class PatrolMovement : IMovementStrategy
    {
        private float _speed = 2f;
        private float _direction = 1f;

        public void Move(Transform transform)
        {
            transform.Translate(Vector3.right * _direction * _speed * Time.deltaTime);
            if (transform.position.x > 5 || transform.position.x < -5)
                _direction *= -1;
        }
    }
}
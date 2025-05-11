using UnityEngine;

namespace Patterns.Strategy
{
    public class EnemyAI : MonoBehaviour
    {
        private IMovementStrategy _movementStrategy;

        [SerializeField] private Transform player;

        void Start()
        {
            _movementStrategy = new PatrolMovement();
        }

        void Update()
        {
            _movementStrategy.Move(transform);

            if (Vector3.Distance(transform.position, player.position) < 3f)
            {
                _movementStrategy = new ChaseMovement(player);
            }
        }
    }
}
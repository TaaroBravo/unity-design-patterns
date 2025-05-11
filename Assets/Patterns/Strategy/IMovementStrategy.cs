using UnityEngine;

namespace Patterns.Strategy
{
    public interface IMovementStrategy
    {
        void Move(Transform transform);
    }
}
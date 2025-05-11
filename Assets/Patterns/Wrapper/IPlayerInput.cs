using UnityEngine;

namespace Patterns.Wrapper
{
    public interface IPlayerInput
    {
        Vector2 GetMovement();
        bool IsJumpPressed();
    }
}
using UnityEngine;

namespace Patterns.Wrapper
{
    public class KeyboardInput : IPlayerInput
    {
        public Vector2 GetMovement()
        {
            return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        public bool IsJumpPressed()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}
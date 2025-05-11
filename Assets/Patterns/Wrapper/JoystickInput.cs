using UnityEngine;

namespace Patterns.Wrapper
{
    public class JoystickInput : IPlayerInput
    {
        public Vector2 GetMovement()
        {
            return new Vector2(Input.GetAxisRaw("JoystickHorizontal"), Input.GetAxisRaw("JoystickVertical"));
        }

        public bool IsJumpPressed()
        {
            return Input.GetButtonDown("JoystickJump");
        }
    }
}
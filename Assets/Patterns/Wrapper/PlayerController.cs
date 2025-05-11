using UnityEngine;

namespace Patterns.Wrapper
{
    public class PlayerController : MonoBehaviour
    {
        private IPlayerInput _input;

        [SerializeField] private bool useJoystick = false;

        private void Awake()
        {
            _input = useJoystick ? new JoystickInput() : new KeyboardInput();
        }

        void Update()
        {
            Physics.Raycast(Vector3.zero, Vector3.back);
            
            Vector2 move = _input.GetMovement();
            if (move != Vector2.zero)
                Debug.Log("Moviendo: " + move);

            if (_input.IsJumpPressed())
                Debug.Log("Salto");
        }
    }
}
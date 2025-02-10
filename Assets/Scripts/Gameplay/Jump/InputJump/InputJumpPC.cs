using System;


namespace Assets.Scripts.Gameplay.InputJump.Installer
{
    public class InputJumpPC : IJumpInput
    {
        private readonly PlayerInputActions _input;
        public InputJumpPC(PlayerInputActions input)
        {
            _input = input;
        }

        public event Action StartJump;
        public event Action CancelJump;

        public void Subscribe()
        {
            _input.Gameplay.Jump.started += _ => StartJump?.Invoke(); ;
            _input.Gameplay.Jump.canceled += _ => CancelJump?.Invoke();
        }
        public void Unsubscribe()
        {
            _input.Gameplay.Jump.performed -= _ => StartJump.Invoke();
            _input.Gameplay.Jump.canceled -= _ => CancelJump.Invoke();
        }
    }
}

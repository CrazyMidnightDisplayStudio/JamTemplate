using Zenject;

namespace Assets.Scripts.Gameplay.InputJump.Installer
{
    public class InputJumpInstaller: MonoInstaller
    {
        private InputJumpPC _inputJump;
        private PlayerInputActions _playerInput;
        public override void InstallBindings()
        {
            _playerInput = new PlayerInputActions();
            _playerInput.Enable();
            _inputJump = new InputJumpPC(_playerInput);
            _inputJump.Subscribe();
            Container.Bind<IJumpInput>().FromInstance(_inputJump).AsSingle();
        }
        private void OnDestroy()
        {
            if(_inputJump != null) _inputJump.Unsubscribe();
            _playerInput.Disable();
        }
    }
}

using System;

namespace Assets.Scripts.Gameplay.InputJump.Installer
{
    public interface IJumpInput
    {
        event Action StartJump;
        event Action CancelJump;
    }
}

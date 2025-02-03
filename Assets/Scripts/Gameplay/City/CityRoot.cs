using UnityEngine;

namespace Gameplay.City
{
    public static class CityRoot
    {
        public static Vector3 RootPosition => new Vector3(7.5f, 0f, 0f);
        public static Vector3 MoveDirection => Vector3.back;

        public static Quaternion RotateDirection => Quaternion.Euler(0f, 90f, 0f);
    }
}

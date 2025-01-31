using UnityEngine;

namespace Gameplay.City
{
    public class CityTile : MonoBehaviour
    {
        public void Move()
        {
            transform.Translate(CityRoot.MoveDirection, Space.World);
        }
    }
}

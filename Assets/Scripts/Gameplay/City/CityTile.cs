using UnityEngine;

namespace Gameplay.City
{
    public class CityTile : MonoBehaviour
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                name = $"CityTile{_id}";
            }
        }

        public Vector3 GetPosition() => transform.position;
        public Vector3 GetSize() => new Vector3(15f, 1f, 15f);

        public bool isTilePassedByPlayer()
        {
            return GetPosition().z < CityRoot.RootPosition.z;
        }
        public void Move(float speed)
        {
            transform.Translate(CityRoot.MoveDirection * speed * Time.deltaTime, Space.World);
        }
    }
}

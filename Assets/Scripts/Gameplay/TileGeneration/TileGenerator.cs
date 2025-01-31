using Gameplay.City;
using UnityEngine;

namespace Gameplay.TileGeneration
{
    public class TileGenerator : MonoBehaviour
    {
        [SerializeField] private CityTile _prefab;

        public CityTile Generate(Vector3 position, Transform parent)
        {
            return Instantiate(_prefab, position, Quaternion.identity, parent);
        }
    }
}

using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Gameplay.TileGeneration;
using Gameplay.Utils;
using UnityEngine;

namespace Gameplay.City
{
    public class CityMover : MonoBehaviour
    {
        [SerializeField] private TileGenerator _tileGenerator;

        private RotateObject _rotator = new RotateObject();
        private Queue<CityTile> _tiles = new Queue<CityTile>();
        private bool isRotating = false;

        private void Start()
        {
            _tiles.Enqueue(_tileGenerator.Generate(Vector3.zero, transform));
        }

        private void FixedUpdate()
        {
            foreach (var tile in _tiles)
            {
                tile.Move();
            }
        }

        public async void Rotate()
        {
            if (isRotating) return;

            isRotating = true;
            await _rotator.RotateToAngleTask(transform, CityRoot.RotateDirection, 1f);
            isRotating = false;
        }

        private void OnDestroy()
        {
            _rotator.Dispose();
        }
    }
}

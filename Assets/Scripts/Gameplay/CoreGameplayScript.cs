using System;
using Gameplay.City;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Gameplay
{
    public class CoreGameplayScript : MonoBehaviour
    {
        [SerializeField] private CityMover _cityMover;
        private PlayerInputActions _controls;

        private void Awake()
        {
            _controls = new PlayerInputActions();
        }

        private void OnEnable()
        {
            _controls.Gameplay.Enable();
            _controls.Gameplay.Turn.performed += OnRotate;
        }

        private void OnDisable()
        {
            _controls.Gameplay.Turn.performed -= OnRotate;
            _controls.Gameplay.Disable();
        }
        private void OnRotate(InputAction.CallbackContext context)
        {
            Debug.Log("Rotate");
            _cityMover.Rotate();
        }
    }
}

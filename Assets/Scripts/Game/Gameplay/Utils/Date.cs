using UnityEngine;
using System;

namespace Game.Gameplay.Utils
{
    public class Date : MonoBehaviour
    {
        private float _dateDuration;
        private float _dateTimer;
        private bool _isActive;

        private Action _onDate;
        private Action _onEndDate;

        public void StartDate(float duration, Action onDate, Action onEndDate)
        {
            _dateDuration = duration;
            _dateTimer = 0f;
            _onEndDate = onEndDate;
            _isActive = true;

            Debug.Log("Date started!");
        }

        void Update()
        {
            if (!_isActive) return;

            _onDate?.Invoke();

            _dateTimer += Time.deltaTime;
            if (_dateTimer >= _dateDuration)
            {
                EndDate();
            }
        }

        /// <summary>
        /// Завершить свидание до истечения таймера, к примеру если шкала заполнилась раньше таймера
        /// </summary>
        public void StopDate()
        {
            EndDate();
        }

        private void EndDate()
        {
            if (!_isActive) return;

            _isActive = false;
            Debug.Log("Date ended!");

            _onEndDate?.Invoke(); // Сообщаем о завершении
        }
    }
}

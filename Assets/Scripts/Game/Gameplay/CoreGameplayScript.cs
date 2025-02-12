using Game.Gameplay.Utils;
using UnityEngine;

namespace Game.Gameplay
{
    public class CoreGameplayScript : MonoBehaviour
    {
        public Player Player;
        private Date _date;

        // тут может быть логика создания игрока, при выборе имени, зодиака и фигуры
        // TODO: Player = new();

        // TODO: написать скрипт по потбору опонента

        private void Awake()
        {
            GameObject dateObject = new GameObject("Date");
            _date = dateObject.AddComponent<Date>();
        }

        public void StartDate(Opponent opponent, float dateTime)
        {
            _date.StartDate(dateTime, OnDate, OnDateEnd);
        }

        public void StopDate()
        {
            _date.StopDate();
        }

        private void OnDate()
        {
            // код который исполняется во время свидания
        }

        private void OnDateEnd()
        {
            Debug.Log("Date finished in CoreGameplayScript");
        }
    }
}


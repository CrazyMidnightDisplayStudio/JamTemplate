using UnityEngine;

namespace Game.Gameplay
{
    public class CoreGameplayScript : MonoBehaviour
    {
        public Player Player;

        private Coroutine _dateCoroutine;

        // тут может быть логика создания игрока, при выборе имени, зодиака и фигуры
        // TODO: Player = new();

        // TODO: написать скрипт по потбору опонента

        public async void StartDateRoutine(Opponent opponent)
        {
            // тут будет цикл с таймером
        }
    }
}

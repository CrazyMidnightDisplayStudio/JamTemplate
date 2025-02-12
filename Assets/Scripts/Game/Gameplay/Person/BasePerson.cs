using Game.Gameplay.Taro;
using UnityEngine.UIElements;

namespace Game.Gameplay
{
    public abstract class BasePerson
    {
        public enum FigureType
        {
            One,
            Two
        }

        public readonly string Name;
        public readonly Zodiac Zodiac;
        public readonly FigureType Figure;

        protected BasePerson(string name, Zodiac zodiac, FigureType figure)
        {
            Name = name;
            Zodiac = zodiac;
            Figure = figure;
        }
    }
}

using Game.Gameplay.Taro;

namespace Game.Gameplay
{
    public struct OpponentPreferences
    {
        public BasePerson.FigureType FigureType;
        // etc
    }

    public class Opponent : BasePerson
    {
        public OpponentPreferences Preferences;

        public Opponent(string name, Zodiac zodiac, FigureType figure) : base(name, zodiac, figure) { }
    }
}

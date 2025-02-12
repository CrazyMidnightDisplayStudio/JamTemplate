using System.Collections.Generic;
using Game.Gameplay.Perks;
using Game.Gameplay.Taro;

namespace Game.Gameplay
{
    public class Player : BasePerson
    {
        public TaroCard TaroCard { get; set; }
        public List<IPerk> Perks { get; set; } = new List<IPerk>();

        public Player(string name, Zodiac zodiac, FigureType figure) : base(name, zodiac, figure) { }
    }
}

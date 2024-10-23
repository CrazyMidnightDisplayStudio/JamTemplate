using UnityEngine;

namespace Assets.Scripts.Core.Inventory
{
    public interface IItem
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public Sprite Icon { get; protected set; }
        public Vector2 Size { get; protected set; }
    }
}

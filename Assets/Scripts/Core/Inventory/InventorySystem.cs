using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assets.Scripts.Core.Inventory
{
    public class InventorySystem
    {
        private Dictionary<IItem, int> _items = new Dictionary<IItem, int>();
        public IReadOnlyDictionary<IItem, int> Items => new ReadOnlyDictionary<IItem, int>(_items);

        public void AddItem(IItem item, int quantity)
        {
            if(_items.ContainsKey(item))
            {
                _items[item] += quantity;
            } else
            {
                _items.Add(item, quantity);
            }
        }

        public (IItem, int) GetItem(IItem item, int quantity)
        {
            if (item == null || quantity <= 0 || !_items.ContainsKey(item))
            {
                return (null, 0);
            }

            var currentQuantity = _items[item];
            if (currentQuantity < quantity)
            {
                return (null, 0);
            }

            _items[item] = currentQuantity - quantity;

            if (_items[item] == 0)
            {
                _items.Remove(item);
            }

            return (item, quantity);
        }

    }
}

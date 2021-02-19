using Module2Task2.Entities;

namespace Module2Task2
{
    class Cart
    {
        private Item[] _allItems = new Item[10];
        private int _cartItemsCount = 0;

        public void AddItem(Item item)
        {
            _allItems[_cartItemsCount] = item;
            _cartItemsCount++;
        }

        public Item[] GetAllItems()
        {
            return _allItems;
        }

        public void ClearCart()
        {
            for (var i = 0; i < _allItems.Length; i++)
            {
                _allItems[_cartItemsCount] = null;
            }
        }
    }
}
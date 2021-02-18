using Module2Task2.Entities;
using Module2Task2.Enums;
using System;

namespace Module2Task2
{
    class Cart
    {
        private Item[] _allItems = new Item[15];
        private int _cartItemsCount = 0;

        public void AddItem(int id, string name, decimal price, Currency currency, MeasureUnits measureUnit, Countries сountryOfOrigin)
        {
            _allItems[_cartItemsCount] = new Item { Id = id, Name = name, Price = price, Currency = currency, MeasureUnit = measureUnit, CountryOfOrigin = сountryOfOrigin };
            _cartItemsCount++;
        }

        public Item[] GetAllItems()
        {
            return _allItems;
        }
    }
}
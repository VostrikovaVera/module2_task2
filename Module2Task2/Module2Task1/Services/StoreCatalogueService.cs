using Module2Task2.Entities;
using Module2Task2.Enums;
using System;

namespace Module2Task2
{
    class StoreCatalogueService
    {
        private static readonly StoreCatalogueService _instance = new StoreCatalogueService();
        private Item[] _allItems = new Item[15];
        private int _catalogueItemsCount = 0;

        static StoreCatalogueService()
        {
        }

        private StoreCatalogueService()
        {
        }

        public static StoreCatalogueService Instance => _instance;

        public void AddItem(int id, string name, decimal price, Currency currency, MeasureUnits measureUnit, Countries сountryOfOrigin)
        {
            _allItems[_catalogueItemsCount] = new Item { Id = id, Name = name, Price = price, Currency = currency, MeasureUnit = measureUnit, CountryOfOrigin = сountryOfOrigin };
            _catalogueItemsCount++;
        }

        public Item[] GetAllItems()
        {
            return _allItems;
        }
    }
}
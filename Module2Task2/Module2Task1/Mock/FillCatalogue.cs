using Module2Task2.Enums;

namespace Module2Task2.Mock
{
    class CatalogDataProvider
    {
        private readonly StoreCatalogueService _storeCatalogue = StoreCatalogueService.Instance;

        public void EnterItemsData ()
        {
            _storeCatalogue.AddItem(1, "Apple", 20, Currency.UAH, MeasureUnits.Kilo, Countries.Ukraine);
            _storeCatalogue.AddItem(2, "Pear", 30, Currency.UAH, MeasureUnits.Kilo, Countries.Turkey);
            _storeCatalogue.AddItem(3, "Pineaple", 65, Currency.UAH, MeasureUnits.SingleItem, Countries.Egypt);
            _storeCatalogue.AddItem(4, "Orange", 30, Currency.UAH, MeasureUnits.Kilo, Countries.Spain);
            _storeCatalogue.AddItem(5, "Strawberry", 110, Currency.UAH, MeasureUnits.Pack, Countries.Israel);
            _storeCatalogue.AddItem(6, "Grapes", 80, Currency.UAH, MeasureUnits.Kilo, Countries.Ukraine);
            _storeCatalogue.AddItem(7, "Potato", 12, Currency.UAH, MeasureUnits.Kilo, Countries.Ukraine);
            _storeCatalogue.AddItem(8, "Tomato", 20, Currency.UAH, MeasureUnits.Kilo, Countries.Turkey);
            _storeCatalogue.AddItem(9, "Cucumber", 20, Currency.UAH, MeasureUnits.Kilo, Countries.Turkey);
            _storeCatalogue.AddItem(10, "Lettuce", 20, Currency.UAH, MeasureUnits.Pack, Countries.Ukraine);
        }
    }
}

using Module2Task2.Entities;
using Module2Task2.Enums;
using Module2Task2.Mock;
using Module2Task2.Services;
using System;

namespace Module2Task2
{
    public class Starter
    {
        private int _orderNumber = 0;
        private readonly CatalogDataProvider _catalogDataProvider = new CatalogDataProvider();
        private readonly User _user = new User { FirstName = "John", LastName = "Doe", Email = "j.doe@gmail.com", PhoneNumber = "123123123123",PrefferedNotificationMethod = NotificationMethods.Email };
        private readonly StoreCatalogue _storeCatalogue = StoreCatalogue.Instance;
        private readonly Cart _cart = new Cart();
        private readonly int _minRandomAction = 0;
        private readonly int _maxRandomAction = 9;
        private readonly Random _random = new Random();
        private readonly CheckoutService _checkoutService = new CheckoutService();

        public void Run ()
        {
            _catalogDataProvider.EnterItemsData();

            var allItems = _storeCatalogue.GetAllItems();

            _orderNumber++;

            for (var i = 0; i < 7; i++)
            {
                _cart.AddItem(allItems[_random.Next(_minRandomAction, _maxRandomAction)]);
            }

            var itemsInCart = _cart.GetAllItems();

            _checkoutService.PerformCheckout(itemsInCart, _user, _orderNumber);
        }
    }
}
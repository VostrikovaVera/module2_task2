using Module2Task2.Entities;
using Module2Task2.Enums;
using System;
using System.Text;

namespace Module2Task2.Services
{
    class CheckoutService
    {
        private decimal _orderTotal = 0;
        private readonly StringBuilder _orderNotification = new StringBuilder();
        private readonly NotificationService _notificationService = new NotificationService();

        public string OrderNotification => _orderNotification.ToString();

        public void PerformCheckout(Item[] ItemsInCart, User User, int OrderNumber)
        {
            CountOrderTotal(ItemsInCart);
            NotifyUser(ItemsInCart, User, OrderNumber);
        }

        private void CountOrderTotal (Item[] ItemsInCart)
        {
            for (var i = 0; i < ItemsInCart.Length; i++)
            {
                _orderTotal += ItemsInCart[i].Price;
            }
        }

        private void NotifyUser(Item[] ItemsInCart, User User, int OrderNumber)
        {
            CreateNotification(ItemsInCart, User, OrderNumber);

            _notificationService.SendNotification(User.PrefferedNotificationMethod, OrderNotification);
        }

        private void CreateNotification (Item[] ItemsInCart, User User, int OrderNumber)
        {
            var notificationHeader = $"Hi, {User.FirstName} {User.LastName}!\n Your order #{OrderNumber} is processing now and will be delivered to you soon.\n You order contain following items:\n";
            _orderNotification.AppendLine(notificationHeader);

            for (var i = 0; i < ItemsInCart.Length; i++)
            {
                var itemDescription = $"{ItemsInCart[i].Name} ({ItemsInCart[i].CountryOfOrigin}) - {ItemsInCart[i].Price} {ItemsInCart[i].Currency} per {ItemsInCart[i].MeasureUnit}";
                _orderNotification.AppendLine(itemDescription);
            }

            var notificationFooter = $"Total price of your order is {_orderTotal} UAH";
            _orderNotification.AppendLine(notificationFooter);
        }
    }
}

using Module2Task2.Enums;
using System;

namespace Module2Task2.Entities
{
    class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public NotificationMethods PrefferedNotificationMethod { get; set; }
    }
}

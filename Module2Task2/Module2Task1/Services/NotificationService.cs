using Module2Task2.Enums;
using System;

namespace Module2Task2.Services
{
    class NotificationService
    {
        private readonly EmailService _emailService = new EmailService();
        private readonly SMSService _smsService = new SMSService();

        public void SendNotification(NotificationMethods notificationMethod, string Message)
        {
            if (notificationMethod == NotificationMethods.Email)
            {
                _emailService.SendEmail(Message);
            } else
            {
                _smsService.SendSMS(Message);
            }
        }
    }
}

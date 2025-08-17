using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //Creational design pattern

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email Notification: " + message);

        }
    }
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS Notification: " + message);
        }
    }
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Push Notification: " + message);
        }
    }

    //Create an abstract class with a factory method
    public abstract class NotificationCreator
    {

        //factor method => create the object inside it
        public abstract INotification CreateNotification();
        public void Notify(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }

    //Implement the factory method in concrete subclasses

    public class EmailNotificatonCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification(); 
        }
    }

    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
    public class PushNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}

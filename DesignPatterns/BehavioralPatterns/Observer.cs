using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns
{
    public interface IEventListener
    {
        void update();
    }
    public class EmailMsgListener : IEventListener
    {
        private readonly string _email;
        public EmailMsgListener(string email)
        {
            _email = email;
        }
        public void update()
        {
            //send mail update
            Console.WriteLine("Update from by email");

        }
    }
    public class MobileMsgListener : IEventListener
    {
        private readonly string _username;
        public MobileMsgListener(string username)
        {
            _username = username;
        }
        public void update()
        {
            //send mail update
            Console.WriteLine("Update from by mobile");

        }
    }
    public class NotificationService
    {
        private readonly List<IEventListener> customers;
        public NotificationService()
        {
            customers = new List<IEventListener>();
        }

        public void Subscribe(IEventListener listener)
        {
            customers.Add(listener);
        }
        public void Unsubscribe(IEventListener listener)
        {
            customers.Remove(listener);
        }
        public void notify()
        {
            customers.ForEach(listener => listener.update());
        }
    }

    public class Store
    {
        private readonly NotificationService notificationService;
        public Store()
        {
            notificationService = new NotificationService();
        }
        public void newItemPromotion()
        {
            notificationService.notify();
        }
        public NotificationService GetService()
        {
            return notificationService;
        }
    }
}

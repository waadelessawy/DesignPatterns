using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{
    public interface INotifier
    {
        void Send(string message);
        string GetUserName();
    }

    public class DatabaseService 
    {
        public string GetMailFromUserName(string username)
        {
            return "w@gmail.com";
        }
        public string GetPhoneNumber(string username)
        {
            return "0120000000";
        }
        public string GetFacebookURL(string username)
        {
            return "w@facebook";
        }
    }
    //Wrapped
    public class Notifier : INotifier
    {
        private readonly string username;
        private readonly DatabaseService databaseService;

        public Notifier(string username)
        {
            this.username = username;
            databaseService = new DatabaseService();
        }

        public void Send(string msg)
        {
            string mail = databaseService.GetMailFromUserName(username);
            Console.WriteLine("Sending " + msg + " by mail to " + mail);
        }

        public string GetUserName()
        {
            return username;
        }

        
    }

    //the wrapper of the initial notifier
    public abstract class BaseNotifierDecorator : INotifier
    {
        private readonly INotifier notifier;
        protected readonly DatabaseService databaseService;

        public BaseNotifierDecorator(INotifier notifier)
        {
            this.notifier = notifier;
            databaseService = new DatabaseService();
        }

        public virtual void Send(string message)
        {
            notifier.Send(message);
        }

        public virtual string GetUserName()
        {
            return notifier.GetUserName();
        }

    }

    public class WhatsAppDecorator : BaseNotifierDecorator
    {
        public WhatsAppDecorator(INotifier notifier) : base(notifier)
        {
            
        }
        public override void Send(string msg)
        {
            base.Send(msg);
            string phoneNbr = databaseService.GetPhoneNumber(GetUserName());
            Console.WriteLine("Sending "+ msg +" by whatsapp on "+ phoneNbr);
        }
    }
    public class FacebookDecorator : BaseNotifierDecorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {

        }
        public override void Send(string msg)
        {
            base.Send(msg);
            string facebookUrl = databaseService.GetFacebookURL(GetUserName());
            Console.WriteLine("Sending " + msg + " by facebook on " + facebookUrl);
        }
    }
}

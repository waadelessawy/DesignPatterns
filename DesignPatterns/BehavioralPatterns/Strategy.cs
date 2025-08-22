using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }

    public class CreditCard
    {
        private readonly string _cardNo;
        private readonly string _expiryDate;
        private readonly string _cvv;

        public CreditCard(string cardNo, string expiryDate,string cvv)
        {
            _cardNo = cardNo;
            _expiryDate = expiryDate;
            _cvv = cvv;

        }
    }
    public class PaymentByCreditCard : IPaymentStrategy
    {
        private CreditCard card;

        public PaymentByCreditCard(CreditCard card)
        {
            this.card = card;
        }

        public void Pay(int amount)
        {

            card = new CreditCard("no", "expirydate", "cvv");
            Console.WriteLine("Paying using credit card");


           
        }
    }
    public class PaymentByPayPal : IPaymentStrategy
    {
        private readonly string email;
        private readonly string password;

        public PaymentByPayPal(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Paying {amount} using PayPal with email {email}");
        }
    }


    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void PayAmount(int amount)
        {
            paymentStrategy.Pay(amount);
        }
    }






}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Task6
{
    public class Customer
    {
        private long CardNumber { set; get; }
        private int Pin { set; get; }
        private string FullName { set; get; }
        private decimal Balance { set; get; }

        public Customer(long cardNumber, int pin, string fullName, decimal balance)
        {
            CardNumber = cardNumber;
            Pin = pin;
            FullName = fullName;
            Balance = balance;
        }

        public long GetCardNumber()
        {
            return CardNumber;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public bool CheckPin(int pin)
        {
            return Pin == pin;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }

}




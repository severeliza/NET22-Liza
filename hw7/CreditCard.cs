using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    internal class CreditCard
    {
        private long Iban { get; }
        private double Amount { get; set; }

        public CreditCard(long iban, double amount) : this(iban)
        {
            Amount = amount;
        }

        public CreditCard(long iban)
        {
            if (iban < 1000000000000)
            {
                throw new ArgumentException("Неверно указан номер счёта.");
            }

            Iban = iban;
            Amount = 0;
        }
        public void Deposit(double amount)
        {
            Amount += amount;
            Console.WriteLine("Операция выполнена успешно.");
        }

        public void WithdrawFromCard(double amount)
        {
            if (Amount >= amount)
            {
                Amount -= amount;
                Console.WriteLine("Операция выполнена успешно.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        public void Info()
        {
            Console.WriteLine($"\nНомер счёта: {Iban}\nСумма на карте: {Amount} BYN");
        }
    }
}

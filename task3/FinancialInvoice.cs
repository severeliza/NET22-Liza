using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class FinancialInvoice : IDocument
    {
        public int DocumentNumber { get; }
        public DateOnly DocumentDate { get; }
        public double TotalMonthAmount { get; }

        public int DepartamentCode { get; }

        public FinancialInvoice(int documentNumber, DateOnly date, double totalMonthAmount, int code)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            TotalMonthAmount = totalMonthAmount;
            DepartamentCode = code;
        }

        public FinancialInvoice(int documentNumber, DateOnly date)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            TotalMonthAmount = 0;
            DepartamentCode = 0;
        }

        public FinancialInvoice(int documentNumber)
        {
            DocumentNumber = documentNumber;
            DocumentDate = DateOnly.FromDateTime(DateTime.Today);
            TotalMonthAmount = 0;
            DepartamentCode = 0;
        }

        public FinancialInvoice()
        {
            DocumentNumber = 0;
            DocumentDate = new DateOnly();
            TotalMonthAmount = 0;
            DepartamentCode = 0;
        }

        public void PrintDocument()
        {
            Console.WriteLine($"Financial invoice N {DocumentNumber}, {DocumentDate}\n" +
                $"Total month amount \t= {TotalMonthAmount}\nDepartament code\t- {DepartamentCode}\n");
        }
    }
}

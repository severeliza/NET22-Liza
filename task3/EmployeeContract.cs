using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class EmployeeContract : IDocument
    {
        public int DocumentNumber { get; }
        public DateOnly DocumentDate { get; }

        public DateOnly? ContractStart { get; }
        public DateOnly? ContractEnd { get; }

        public String? EmployeeName { get; }

        public EmployeeContract(int documentNumber, DateOnly date, DateOnly start, DateOnly end, string employeeName)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            ContractStart = start;
            ContractEnd = end;
            EmployeeName = employeeName;
        }

        public EmployeeContract(int documentNumber, DateOnly date)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            ContractStart = null;
            ContractEnd = null;
            EmployeeName = null;
        }

        public EmployeeContract(int documentNumber)
        {
            DocumentNumber = documentNumber;
            DocumentDate = DateOnly.FromDateTime(DateTime.Today);
        }

        public EmployeeContract()
        {
            DocumentNumber = 0;
            DocumentDate = new DateOnly();
            ContractStart = null;
            ContractEnd = null;
            EmployeeName = null;
        }

        public void PrintDocument()
        {
            Console.WriteLine($"Employee contract N {DocumentNumber}, {DocumentDate}\n" +
                $"Employee name: {EmployeeName}\nContract: from {ContractStart} till {ContractEnd}\n");
        }
    }
}

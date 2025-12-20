using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class SupplyOfGoods : IDocument
    {
        public int DocumentNumber { get; }
        public DateOnly DocumentDate { get; }

        public SupplyType? Type { get; }
        public int Qty { get; }

        public SupplyOfGoods(int documentNumber, DateOnly date, SupplyType type, int qty)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            Type = type;
            Qty = qty;
        }

        public SupplyOfGoods(int documentNumber, DateOnly date)
        {
            DocumentNumber = documentNumber;
            DocumentDate = date;
            Type = null;
            Qty = 0;
        }

        public SupplyOfGoods(int documentNumber) 
        {
            DocumentNumber = documentNumber;
            DocumentDate = DateOnly.FromDateTime(DateTime.Today);
            Type = null;
            Qty = 0;
        }

        public SupplyOfGoods()
        {
            DocumentNumber = 1;
            DocumentDate = new DateOnly();
            Type = null;
            Qty = 0;
        }

        public void PrintDocument()
        {
            Console.WriteLine($"SupplyOfGoods N {DocumentNumber}, {DocumentDate}\n{Qty} of {Type}\n");
        }
    }
}

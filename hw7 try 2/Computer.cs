using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw7_try_2
{
    internal class Computer
    {
        private String model;
        private double price;
        private RAM ram;
        private HDD hdd;

        public Computer(String model, double price, RAM ram, HDD hdd) : this (model, price)
        { 
            this.ram = ram;
            this.hdd = hdd;
        }

        public Computer(String model, double price)
        {
            this.model = model;
            this.price = price;
            ram = new RAM();
            hdd = new HDD();
        }

        public void Info()
        {
            Console.WriteLine($"Computer: Model - {model}, price - {price}");
            ram.Info();
            hdd.Info();
        }
    }
}

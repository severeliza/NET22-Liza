using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw6
{
    internal class Phone
    {
        private string _number;
        private string _model;
        private double _weight;

        public Phone(string number, string model, double weight) : this(number, model)
        {
            _weight = weight;
        }

        public Phone(string number, string model)
        {
            _number = number;
            _model = model;
            _weight = 0;
        }

        // не знаю как лучше по оформлению

        public string Model 
        { 
            get 
            { 
                return _model; 
            } 
        }  

        public double Weight { get { return _weight; } }

        public String GetNumber()
        {
            return _number;
        }

        public void ReceiveCall(string name)
        { 
            Console.WriteLine($"{name} is calling");
        }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"{name} (number: {number}) is calling");
        }

        //Создать метод sendMessage с аргументами переменной длины.
        //Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение.
        //Метод выводит на консоль номера этих телефонов.
        public void SendMessage(params string[] numbers)
        {
            foreach (string number in numbers)
            {
                Console.WriteLine($"Send message to: {number}");
            }
        }

    }
}

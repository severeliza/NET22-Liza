using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_try_2
{
    enum HDDType
    {
        internalHDD,
        externalHDD
    }
    
    internal class HDD
    {
        private string name;
        private int capacity;
        private HDDType hDDType;

        public HDD(string name, int capacity, HDDType hDDType)
        {
            this.name = name;
            this.capacity = capacity;
            this.hDDType = hDDType;
        }

        public HDD()
        {
            this.name = "unknown";
            this.capacity = 0;
            this.hDDType = HDDType.internalHDD;
        }

        public void Info()
        {
            Console.WriteLine($"HDD: Name - {name}, capacity - {capacity}, hdd type - {hDDType}");
        }
    }
}

using hw6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp
{
    internal class TreatmentPlan
    {
        private List<int> doctors;
        List<IDoctor> doctorList;

        public TreatmentPlan()
        {
            doctors = new List<int>();
            doctorList = new List<IDoctor>();
        }

        public TreatmentPlan(int[] doctorsList)
        {
            doctors = new List<int>();
            doctorList = new List<IDoctor>();

            foreach (int code in doctorsList)
            {
                AddDoctor(code);
            }
        }

        public void AddDoctor(int code)
        {
            doctors.Add(code);

            switch (code)
            {
                case 1:
                    doctorList.Add(new Surgeon());
                    break;
                case 2:
                    doctorList.Add(new Dentist());
                    break;
                default:
                    doctorList.Add(new Therapist());
                    break;
            }
        }

        public IDoctor NextDoctor()
        {
            return doctorList.First();
        }

        public void RemoveDoctor()
        {
            if (doctorList.Count > 0)
            {
                doctors.RemoveAt(0);
                doctorList.RemoveAt(0);
            }
        }

        public void PrintPlan()
        {
            Console.WriteLine("План лечения: ");

            foreach (var item in doctors)
            {
                Console.Write(item);
            }

            Console.WriteLine();

        }
        

    }
}

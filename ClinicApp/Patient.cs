using hw6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp
{
    internal class Patient
    {
        private TreatmentPlan _plan;

        public String Name { get; }

        public Patient(String name = "anonim")
        {
            Name = name;
        }

        public void AddTreatmentPlan(int[] doctorsList)
        {
            _plan = new TreatmentPlan(doctorsList);
            _plan.PrintPlan();
        }

        public void AddTreatmentPlan()
        {
            _plan = new TreatmentPlan();
            _plan.PrintPlan();
        }

        public void AddDoctor(int code)
        {
            _plan.AddDoctor(code);
            _plan.PrintPlan();
        }

        public void AppointDoctor()
        {
            _plan.NextDoctor().Treat();
            _plan.RemoveDoctor();
        }


    }
}

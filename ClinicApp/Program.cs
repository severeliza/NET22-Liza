using ClinicApp;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Patient patient1 = new Patient("Liza");

patient1.AddTreatmentPlan(new int[]{ 1, 2, 1, 3 });

patient1.AppointDoctor();
patient1.AppointDoctor();

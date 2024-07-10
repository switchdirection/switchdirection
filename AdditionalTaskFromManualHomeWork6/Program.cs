namespace AdditionalTaskFromManualHomeWork6
{
    static class Surgeon
    {
        public static void Heal()
        {
            Console.WriteLine("Так лечит Хирург!");
        }
    }

    static class Internist
    {
        public static void Heal()
        {
            Console.WriteLine("Так лечит Терапевт!");
        }
    }

    static class Dentist
    {
        public static void Heal()
        {
            Console.WriteLine("Так лечит Дантист!");
        }
    }

    internal class Patient
    {
        public TreatmentPlan _plan;

        public TreatmentPlan Plan { get { return _plan; } set { _plan = value; } }

        public Patient(TreatmentPlan plan)
        {
            Plan = plan;
        }

        public void PrescribeTreatment()
        {
            if(Plan!= null)
            {
                switch(Plan.DoctorCode)
                {
                    case 1:
                        {
                            Console.WriteLine("Вам назначен хирург.");
                            Surgeon.Heal();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Вам назначен дантист.");
                            Dentist.Heal();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вам назначен терапевт.");
                            Internist.Heal();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого врача пока что нет в нашей клиннике!");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("У пациента нет плана лечения!");
            }
        }
    }

    internal class TreatmentPlan
    {
        private int _doctorCode;
        public int DoctorCode { get { return _doctorCode; } set { _doctorCode = value; } }

        public TreatmentPlan(int doctorCode)
        {
            DoctorCode = doctorCode;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TreatmentPlan plan = new TreatmentPlan(1);
            TreatmentPlan plan1 = new TreatmentPlan(2);
            TreatmentPlan plan2 = new TreatmentPlan(3);
            TreatmentPlan plan3 = new TreatmentPlan(4);

            Patient patient = new Patient(plan);
            Patient patient1 = new Patient(plan1);
            Patient patient2 = new Patient(plan2);
            Patient patient3 = new Patient(plan3);

            Console.WriteLine("Patient: ");
            patient.PrescribeTreatment();
            Console.WriteLine();
            Console.WriteLine("Patient1: ");
            patient1.PrescribeTreatment();
            Console.WriteLine();
            Console.WriteLine("Patient2: ");
            patient2.PrescribeTreatment();
            Console.WriteLine();
            Console.WriteLine("Patient3: ");
            patient3.PrescribeTreatment();
            Console.WriteLine();

        }
    }
}

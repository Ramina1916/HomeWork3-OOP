using hw03_task04.Factories;
using hw03_task04.Strategies;

namespace hw03_task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("☆*: .｡. Hospital Managment System Test .｡.:*☆\n");

            // Singleton
            Hospital hospital = Hospital.Instance;

            // add room 
            hospital.AddRoom(new Room(101, 2));


            // create patient and doctor instance
            Doctor doctor = DoctorFactory.Create("Sara Ahmadi", 45, "1234567890", 1, "Cardiology"); // instead of creating new doctor, we call doctor factory
            hospital.AddDoctor(doctor);


            try
            {
                Console.Write("Patient name: ");
                string name = Console.ReadLine()!;

                Console.Write("Patient age: ");
                int age = int.Parse(Console.ReadLine()!);

                Console.Write("Patient national ID: ");
                string nationalId = Console.ReadLine()!;

                Console.Write("Patient ID number: ");
                string patientId = (Console.ReadLine()!);

                Patient patient = new Patient(name, age, nationalId, patientId);

                hospital.AdmitPatient(patient);
                Console.WriteLine("Patient admitted.");

                Console.Write("Symptoms: ");
                string symptoms = Console.ReadLine()!;
                doctor.Diagnose(patient, symptoms);

                Console.WriteLine("Doctor info: ");
                Console.WriteLine(doctor.GetDetails());

                Console.WriteLine("Patient info: ");
                Console.WriteLine(patient.GetDetails());

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Invalid operation: {ex.Message}");
            }
        }
    }
}

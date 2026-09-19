namespace hw03_task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("☆*: .｡. Hospital Managment System Test .｡.:*☆");
            // Singleton
            Hospital hospital = Hospital.Instance;

            // add room 
            hospital.AddRoom(new Room(101, 1));
            

            // create patient and doctor instance
            Doctor doctor = new Doctor("Sara Ahmadi", 45, "1234567890", 1, "Cardiology");
            Patient first = new Patient("Ali Rezaei", 30, "234503595", "567");
            Patient second = new Patient("Nima Karimi", 28, "1122334455", "5826");


            try
            {
                hospital.AdmitPatient(first);
                doctor.Diagnose(first, "flu");

                hospital.AdmitPatient(second);

                Console.WriteLine(first.GetDetails());
                Console.WriteLine(doctor.GetDetails());

                hospital.AdmitPatient(second);
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

namespace hw03_task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implementation of university management system
            Console.WriteLine("Hello, Daneshkar!👋🏻");
            List<Person> members = new List<Person>
            {
                new Student("Arnika GholiZadeh", 20, "S2023001", "Computer Science"),
                new Professor("Dr. Akbari", 45, "P100", "Algorithms"),
                new Student("Jamshid MohammadAliAbadi", 22, "S2023002", "Mathematics"),
                new Professor("Dr. HosseinZadeh", 52, "P101", "Physics")
            };

            foreach (Person person in members)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}

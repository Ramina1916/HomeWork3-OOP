namespace hw03_task03
{
    internal class Program
    {
        static public void DisplayElectronics()
        {
            List<Product> electronics = new List<Product>
            {
                new Electronic("Smartphone", 699.99m, 24),
                new Electronic("Television", 1299.99m, 36),
                new Electronic("Laptop", 999.99m, 12),
                new Electronic("Headphones", 199.99m, 6)
            };

            Console.WriteLine("\n--- Electronics Catalog ---");
            foreach (var item in electronics)
            {
                Console.WriteLine(item.GetProductDetails());
            }
        }

        static public void DisplayClothing()
        {
            List<Product> clothing = new List<Product>
            {
                new Clothing ("T-Shirt", 19.99m, "M", "Cotton"),
                new Clothing ("Jeans", 49.99m, "L", "Denim"),
                new Clothing ("Jacket", 89.99m, "XL", "Leather"),
                new Clothing ("Sweater", 39.99m, "S", "Wool")
            };

            Console.WriteLine("\n--- Clothing Catalog ---");
            foreach (var item in clothing)
            {
                Console.WriteLine(item.GetProductDetails());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Daneshkar!");

            Console.WriteLine("\nWhich catalog do you want to see?");
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Clothing");
            Console.Write("Enter your choice (1 or 2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayElectronics();
            }
            else if (choice == "2")
            {
                DisplayClothing();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the program.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. convert segment data to number");
            Console.WriteLine("2. convert number to segment data");
            Console.WriteLine("3. exit");

            Console.Write("Choose an option (1-3): ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try with new input.");
                    break;
            }

            Console.WriteLine();
        }
    }

}

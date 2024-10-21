class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. convert segment data to number");
            Console.WriteLine("2. convert number to segment data");
            Console.WriteLine("3. exit");

            Console.Write("choose an option (1-3): ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertSegmentDataToNumber();
                    break;
                case "2":
                    ConvertNumberToSegmentData();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("please try with new input, invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
    static void ConvertSegmentDataToNumber()
    {
        Console.Write("enter the 7-segment display data (7 digits of 0s and 1s): ");
        string? input = Console.ReadLine();

        try
        {
            int result = SevenSegmentReader.ConvertToNumber(input!);
            Console.WriteLine($"the number represented is: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void ConvertNumberToSegmentData()
    {
        Console.Write("enter a number (0-9): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            try
            {
                string result = SevenSegmentReader.ConvertToSegmentData(number);
                Console.WriteLine($"the 7-segment display data is: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("please enter a number between 0 and 9, invalid input.");
        }
    }

}

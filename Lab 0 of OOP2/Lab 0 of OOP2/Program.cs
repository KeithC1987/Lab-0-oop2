namespace lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task one");

            int lowNumber = GetPositiveNumber("Please enter the low number: ");

            int highNumber = HighGreaterThanLow("Please enter the high number which is greather than low number : ", lowNumber);

            int difference = highNumber - lowNumber;

            Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");
        }
        static int GetPositiveNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {

                    return number;
                }

                else
                {
                    Console.WriteLine($"Please enter a positive number");
                }

            }

        }
        static int HighGreaterThanLow(string prompt, int low)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int number) && number > low)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"Please enter a number greater than {low}.");
                }
            }



        }



    }

    
}

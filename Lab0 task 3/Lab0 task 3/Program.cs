namespace Lab0Task3
{
    class program
    {
        static void Main(string[] args)
        {
            int[] NumArray = { 1, 2, 3, 4, 5, 6 };
            foreach (int num in NumArray)
            {
                Console.Write(num);
            }



            using (StreamWriter sw = new StreamWriter("C:\\Users\\ASUS\\Desktop\\Lab0 task 3\\number.txt"))
            {
                foreach (int num in NumArray)
                {
                    Console.WriteLine(num);
                    sw.WriteLine(num);
                }
            }

            string filePath = "C:\\Users\\ASUS\\Desktop\\Lab0 task 3\\number.txt";
            int[] numbers = { 1, 2,3, 4, 5, 6 };

            Array.Reverse(numbers);

            using (StreamWriter  writer = new StreamWriter(filePath))
            {
                foreach ( int num in numbers) 
                {
                    Console.Write(num);
                    writer.WriteLine(num);
                }
            }
            string file = "C:\\Users\\ASUS\\Desktop\\Lab0 task 3\\number.txt";
            int sum = 0;

            using(StreamReader reader = new StreamReader(file)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line,out int number))
                    {
                        sum += number;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"The sum of number is {sum}.");

            List<double> ListOfNumber = new List<double>();
            for (int i = 0;i <20; i++)
            {
                ListOfNumber.Add(i*10);
                Console.WriteLine($"The value of the List at index {i} is: {ListOfNumber[i]}");

            }

            int lowNumber = 15;
            int highNumber = 55;

            for(int i = lowNumber; i<=highNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }

            }



        }
        static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0) 
            {
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i++) 
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

        





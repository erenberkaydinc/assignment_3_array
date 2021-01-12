using System;

namespace assignment_3_arrayay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Please enter number which is bigger than > 1 to search for prime numbers";
            Console.WriteLine(input);

            int number = Convert.ToInt32(Console.ReadLine()); 

            int[] array = new int[number];

            numbersFunction(array, number);

            calcFunction(array, number);

            Results(array, number);
            Console.ReadKey();
        }

        static void numbersFunction(int[] array, int number)
        {
            for (int i = 0; i < number; i++)
            {
                array[i] = i + 1;
            }
            array[0] = 0;
        }

        static void calcFunction(int[] array, int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (array[i] != 0)
                {
                    for (int j = 2; j < Math.Sqrt(number); j++)
                    {
                        if (array[i] == j) array[i] = j;
                        else if (array[i] % j == 0) array[i] = 0;
                    }
                }
            }
        }

        static void Results(int[] array, int number)
        {
            string input = String.Format("That's the Prime numbers from 1 to {0} ", number);
            Console.WriteLine(input);
            for (int i = 0; i < number; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(array[i]);
            }
        }

    }
}

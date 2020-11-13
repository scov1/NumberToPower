using System;

namespace NumberToPower
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input power: ");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * num;
            }

            Console.WriteLine("Number to Power => " + result);

            Console.ReadKey();
        }
    }
}

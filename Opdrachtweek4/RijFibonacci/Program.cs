using System;

namespace RijFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller, getal, getal1 = 0, getal2 = 1, getal3;

            Console.Write("input: ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            Console.WriteLine();
            Console.Write(getal1.ToString());
            Console.WriteLine();
            Console.Write(getal2.ToString());
            Console.WriteLine();
            for(teller = 3; teller <=getal; teller++)
            {
                getal3 = getal1 + getal2;
                getal1 = getal2;
                getal2 = getal3;

                Console.Write(getal3.ToString() + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
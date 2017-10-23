using System;

namespace Priemgetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal, teller, aantal = 0, deler = 1;

            Console.Write("Input(max 100): ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            Console.WriteLine();
            if(getal <= 100)
            {
                for(teller = 1; teller <= getal; teller++)
                {
                    Console.Write(teller.ToString() + " ");
                    aantal = 0;

                    for(deler = 1; deler <= teller; deler++)
                    {
                        if(teller % deler == 0)
                        {

                            aantal++;
                        }
                    }
                    if(aantal == 2)
                    {
                        Console.Write("is een priemgetal");
                    }
                    else{
                        Console.Write("ss geen priemgetal");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            } 
            else
            {
                {
                    Console.WriteLine("Getal moet onder de 100 zijn");
                }
            }
        }
    }
}

using System;
using System.Threading;

delegate void NumberReached(int threadNr);

namespace opdrachtweek11
{
    class Program
    {
        event NumberReached nrEvent;

        public Program()
        {
            this.nrEvent += new NumberReached(printMessage);

        }

        static void Main(string[] args)
        {
            Program x = new Program();

            int max = getmaxInput();
            
            Thread t1 = new Thread(() => t1UserInput(max, x));
            t1.Start();

            Thread t2 = new Thread(() => t2LoopIncrement(max, x));
            t2.Start();

            Thread t3 = new Thread(() => t3Random(max, x));
            t3.Start();
        }

        public static int getmaxInput(){
            Console.WriteLine("Enter max value here");
            int val = Int32.Parse(Console.ReadLine());
            Console.WriteLine("max val: {0}", val);
            return(val);
        }

        public static void t1UserInput(int max, Program x){
            Console.WriteLine("Enter max value here");

            int enteredVal = Int32.Parse(Console.ReadLine());

            do {
                Console.WriteLine("incorrect value");
                enteredVal = Int32.Parse(Console.ReadLine());
            } while (enteredVal != max);

            x.nrEvent(1);

        }

        public static void t2LoopIncrement(int max, Program x){
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine("{0}", i);
                if(i == max){
                    x.nrEvent(2);
                }
            }
        }

        public static void t3Random(int max, Program x){
            Random rnd = new Random();
            int randomVal = rnd.Next(max - 10, max + 10);

            do {
                
                randomVal = rnd.Next(max - 10, max + 10);
            } while (randomVal != max);

            x.nrEvent(3);
        }


        public static void printMessage(int a)
        {
            Console.WriteLine("Thread {0} finished", a);
        }

    }
}
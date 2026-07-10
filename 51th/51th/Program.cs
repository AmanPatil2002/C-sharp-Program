
using System;
using System.Threading;

namespace _51th
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread = An execution path of a program
            //                We can use multiple threads to perform,
            //                different tasksof our program at thesame time.
            //                Current thread running is "main" thread
            //                using System.Threading;
            
            Thread mainThread =Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
                        
            Console.WriteLine(mainThread.Name + " is complete");

            Console.ReadKey();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete ! ");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete ! ");
        }
    }
}
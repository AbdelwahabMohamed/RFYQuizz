using System;
using System.Diagnostics;
using ReadifyServiceConsumer.Mock;
using ReadifyServiceConsumer.RedPillService;
using ReadifyServiceConsumer.MyReadifyService;

namespace ReadifyServiceConsumer
{
    internal class Program
    {
        /*
         * To test the service I created 3 clients, 
         * one is for the service that is provided in the readify site, 
         * the second one is for a mock class I created to isolate the internet speed element from my tetsing
         * The third one is for my hosted service in a trial windows azure account -will be expired by 25-Dec-2015
         */
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter how many times you want the code to run, then hit ENTER: ");
            int rc = int.Parse(Console.ReadLine());

            for (int i = 0; i < rc; i++)
            {
                RunService();
                RunServiceMock();
                RunConsumer();

            }
            Console.WriteLine("Hit ENTER to exit");
            Console.ReadKey();

        }

        /// <summary>
        /// Consuming the web service provided by Readify
        /// </summary>
        private static void RunService()
        {
            Console.WriteLine("Consuming the Readify Service");
            var proxy = new RedPillClient("BasicHttpBinding_IRedPill");

            string toRev = "abcd efgh";
            var s = new Stopwatch();
            //R words
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.ReverseWords(toRev);
            }
            s.Stop();
            Console.WriteLine("Reverse took : " + s.Elapsed.Seconds);

            //F Number
            s.Reset();
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.FibonacciNumber(23);
            }
            s.Stop();
            Console.WriteLine("F  Number took : " + s.Elapsed.Seconds);
            //What is the shape
            s.Reset();
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.WhatShapeIsThis(i, 4, i + 1);
            }
            s.Stop();
            Console.WriteLine("What took : " + s.Elapsed.Seconds);
            Console.WriteLine("======================\n========================");            
        }
  
        /// <summary>
        /// Consuming the Mockup I made to remove the internet speed factor
        /// </summary>
        private static void RunServiceMock()
        {
            Console.WriteLine("Consuming the Mockup Service");
            var proxy = new MyServiceMock();
            string toRev = "abcd efgh asdfghjkl asdfghjk";
            var s = new Stopwatch();
            //R words
            s.Start();
            for (int i = 0; i < 300000; i++)
            {
                proxy.ReverseWords(toRev);
            }
            s.Stop();            
            Console.WriteLine("Reverse took : " + s.Elapsed.Milliseconds);
            //F Number
            s.Reset();
            s.Start();
            for (int i = 0; i < 3000000; i++)
            {
                proxy.FibonacciNumber(23);
            }
            s.Stop();
            Console.WriteLine("F  Number took : " + s.Elapsed.Milliseconds);
            //What is the shape
            s.Reset();
            s.Start();
            for (int i = 0; i < 30000000; i++)
            {
                proxy.WhatShapeIsThis(i, 4, i + 1);
            }
            s.Stop();           
            Console.WriteLine("What took : " + s.Elapsed.Milliseconds);
            Console.WriteLine("======================\n========================");
        }
        
        /// <summary>
        /// Consume the service I developed for the test
        /// </summary>
        private static void RunConsumer()
        {
            Console.WriteLine("Consuming my Task Service");
            var proxy = new MyRedPillServiceClient("BasicHttpsBinding_IMyRedPillService");
            string toRev = "abcd efgh";
            var s = new Stopwatch();
            //R words
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.ReverseWords(toRev);
            }
            s.Stop();
            Console.WriteLine("Reverse took : " + s.Elapsed.Milliseconds);

            //F Number
            s.Reset();
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.FibonacciNumber(23);
            }
            s.Stop();
            Console.WriteLine("F  Number took : " + s.Elapsed.Milliseconds);
            //What is the shape
            s.Reset();
            s.Start();
            for (int i = 0; i < 30; i++)
            {
                proxy.WhatShapeIsThis(i, 4, i + 1);
            }
            s.Stop();
            Console.WriteLine("What took : " + s.Elapsed.Milliseconds);
            Console.WriteLine("======================\n========================");
        }
       
    }
}
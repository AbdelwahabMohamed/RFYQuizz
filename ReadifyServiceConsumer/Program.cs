using System;
using System.Diagnostics;
using ReadifyServiceConsumer.Mock;
using ReadifyServiceConsumer.RedPillService;
using ReadifyServiceConsumer.ServiceReference1;

namespace ReadifyServiceConsumer
{
    internal class Program
    {
        private static void RunService()
        {
            var proxy = new MyRedPillServiceClient();

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

        private static void RunServiceMock()
        {
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
            Console.WriteLine(proxy.ReverseWords(toRev));
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
            Console.WriteLine(proxy.WhatShapeIsThis(1, 1, 1));
            Console.WriteLine(proxy.WhatShapeIsThis(1, 2, 1));
            Console.WriteLine(proxy.WhatShapeIsThis(1, 2, 3));
            Console.WriteLine("What took : " + s.Elapsed.Milliseconds);
            Console.WriteLine("======================\n========================");
        }

        private static void RunConsumer()
        {
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

        private static void Main(string[] args)
        {
            Console.WriteLine("Run Count: ");
            int rc = int.Parse(Console.ReadLine());

            for (int i = 0; i < rc; i++)
            {
                //RunService();
                RunServiceMock();
                //RunConsumer();
            }


        }
    }
}
using System;

namespace RedPillServiceLibrary.Constants
{
    public static class Constants
    {
        public const int MaxIndex = 92;
        public const int MinIndex = -92;
        public static readonly Guid Id = new Guid("d2459599-0836-4e71-8b42-c9c5ccfab6e6");
        public static long[] FSequence;

        static Constants()
        {
            InitFibonacciNumbers();
        }

        static void InitFibonacciNumbers()
        {
            FSequence= new long[185];
            int i = 0;
            long a = 0, b = 1, x = 0;
            while (i <= MaxIndex)
            {
                x = b + a;
                b = a;
                a = x;
                i++;
                FSequence[i] = x;
            }
        }
    }
}
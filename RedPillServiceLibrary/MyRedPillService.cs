using System;
using System.Linq;
using RedPillServiceLibrary.RedPillServiceRef;

namespace RedPillServiceLibrary
{
    public class MyRedPillService : IMyRedPillService
    {
        #region "Service Methods"

        public Guid WhatIsYourToken()
        {
            return Constants.Constants.Id;
        }

        /// <summary>
        ///     Finding  the nth Fibonaccinumber
        /// </summary>
        /// <param name="n">index</param>
        /// <returns>value</returns>
        public long FibonacciNumber(long n)
        {
            if (n < Constants.Constants.MinIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(<92) will cause a 64-bit integer overflow.");
            }

            if (n > Constants.Constants.MaxIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            long absIndex = Math.Abs(n);
            long value = Constants.Constants.FSequence[absIndex];

            return n < 0 && absIndex%2 == 0 ? -value : value;
        }

        /// <summary>
        ///     Finding the tyep of a triangle [Equilateral ,Isosceles, Scalene]
        /// </summary>
        /// <returns>TriangleType enum</returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0) return TriangleType.Error;
            if ((a + b <= c) || (b + c <= a) || (a + c <= b)) return TriangleType.Error;

            if ((a == b && b == c)) return TriangleType.Equilateral;
            if (a == b || a == c || b == c) return TriangleType.Isosceles;
            return TriangleType.Scalene;
        }

        /// <summary>
        ///     Reversing  words in a string "in place"
        /// </summary>
        /// <returns>reversed words</returns>
        public string ReverseWords(string input)
        {
            return String.Join(" ",
                input.Split(' ')
                    .Select(x => new String(x.Reverse().ToArray()))
                    .ToArray());
        }

        #endregion
    }
}
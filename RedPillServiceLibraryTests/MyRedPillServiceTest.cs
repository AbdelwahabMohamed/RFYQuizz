using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPillServiceLibrary;
using RedPillServiceLibrary.RedPillServiceRef;

namespace RedPillServiceLibraryTests
{
    [TestClass]
    public class MyRedPillServiceTest
    {
        public MyRedPillService Service;

        [TestInitialize]
        public void Init()
        {
            Service = new MyRedPillService();
        }

        #region "Fibonacci Number Tests"
        [TestMethod]
        public void FibonacciNumberIndexBetweenPositiveRangeTest()
        {
            long fact1 = Service.FibonacciNumber(5);
            long fact2 = Service.FibonacciNumber(6);
            long fact3 = Service.FibonacciNumber(7);

            Assert.IsTrue(fact3 == fact1 + fact2);
        }

        [TestMethod]
        public void FibonacciNumberIndexBetweenRangeTest()
        {
            long fact1 = Service.FibonacciNumber(-5);
            long fact2 = Service.FibonacciNumber(-6);
            long fact3 = Service.FibonacciNumber(-7);

            Assert.IsTrue(fact1 == fact3 + fact2);
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberIndexOutOfRangeTest()
        {
            long fact1 = Service.FibonacciNumber(93);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberIndexBelowRangeTest()
        {
            long fact1 = Service.FibonacciNumber(-93);
        }
        #endregion

        #region "What Shape Tests"
        [TestMethod]
        public void WhatShapeIsThisAllCasesTest()
        {
            var equatorial = new[] {3, 3, 3};
            var isosceles = new[] {3, 3, 4};
            var scalene = new[] {3, 5, 6};
            TriangleType retequatorial = Service.WhatShapeIsThis(equatorial[0], equatorial[1], equatorial[2]);
            TriangleType retisosceles = Service.WhatShapeIsThis(isosceles[0], isosceles[1], isosceles[2]);
            TriangleType retscalene = Service.WhatShapeIsThis(scalene[0], scalene[1], scalene[2]);
            Assert.IsTrue(retequatorial == TriangleType.Equilateral && retisosceles == TriangleType.Isosceles &&
                          retscalene == TriangleType.Scalene);
        }
        [TestMethod]
        public void WhatShapeIsThisErrorTest()
        {
            var Error = new[] { 1,2, 1 };
            TriangleType error = Service.WhatShapeIsThis(Error[0], Error[1], Error[2]);
            Assert.IsTrue(error == TriangleType.Error);
        }
        [TestMethod]
        public void WhatShapeIsThisZeroTest()
        {
            var zero = new[] { 0, 4, 1 };
            TriangleType Zero = Service.WhatShapeIsThis(zero[0], zero[1], zero[2]);
            Assert.IsTrue(Zero == TriangleType.Error);
        }
        #endregion

        #region "Reverse Words Tests"
        [TestMethod]
        public void ReverseWordsTest()
        {
            const string reversed = "fdsa rewq";
            const string toReverse = "asdf qwer";
            if (Service != null) Assert.AreEqual(Service.ReverseWords(toReverse), reversed);
        }
        #endregion
    }

}
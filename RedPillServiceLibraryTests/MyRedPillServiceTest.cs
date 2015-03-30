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


        [TestMethod]
        public void FibonacciNumberTest()
        {
            long fact1 = Service.FibonacciNumber(5);
            long fact2 = Service.FibonacciNumber(6);
            long fact3 = Service.FibonacciNumber(7);

            Assert.IsTrue(fact3 == fact1 + fact2);
        }

        [TestMethod]
        public void WhatShapeIsThisTest()
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
        public void ReverseWordsTest()
        {
            const string reversed = "fdsa rewq";
            const string toReverse = "asdf qwer";
            if (Service != null) Assert.AreEqual(Service.ReverseWords(toReverse), reversed);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringCalculatorKata
{
    [TestClass]
    public class StringCalculatorTests
    {
        public class Add
        {
            [TestMethod]
            public void EmptyString_ShouldReturnZero()
            {
                var sut = new StringCalculator();
                var result = sut.Add(string.Empty);

                Assert.Equals(result, 0);
            }
        }

        public class StringCalculator
        {
            public int Add(string numberString)
            {
                return 0;
            }
        }
    }
}

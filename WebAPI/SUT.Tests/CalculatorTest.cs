using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SUT.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator sut;
        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Calculator();
        }

        [Ignore("not necessary")]
        public void ShouldAddTwoNumbers()
        {
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Ignore("not necessary")]
        public void ShouldMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }
    }
}

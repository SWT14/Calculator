using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calc = Calculator.Calc;

namespace Calc.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator.Calc uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator.Calc();
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, -2, 0.25)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(9, 0.5, 3.0)]
        [TestCase(16, 0.5, 4.0)]
        public void PowerNumber_Higher_CorrectResult(double a, double b, double resultat)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(resultat));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
using Calc = Calculator.Calc;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator.Calc uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calc();
        }

        
        // Test add med forskellige værdier
        [TestCase(3, 6, 9)]
        [TestCase(-2, 4, 2)]
        [TestCase(-4, -4, -8)]
        public void Test_add(double a, double b, double resultat)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(resultat));
        }

        // Test subtract
        [TestCase(8, 3, 5)]
        [TestCase(3, 6, -3)]
        [TestCase(-2, -4, 2)]
        public void Test_Subtract_ReturnResult(double a, double b, double resultat)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo((resultat)));
        }

        // Test multiply med forskellige værdier
        [TestCase(3, 3, 9)]
        [TestCase(-2, 4, -8)]
        [TestCase(-4, -4, 16)]
        public void Test_multiply(double a, double b, double resultat)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(resultat));
        }

        // Test devide 
        [TestCase(10, 5, 2)]
        [TestCase(5, 2, 2.5)]
        [TestCase(-6, 2, -3)]
        public void Test_Divide_ReturnResult(double a, double b, double resultat)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(resultat));
        }

        // Test power
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


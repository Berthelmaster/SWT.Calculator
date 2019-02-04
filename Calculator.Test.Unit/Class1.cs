using System;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
 [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Addition_Add2and4()
        {
            var uut = new Calculator();
            Assert.That(uut.Addition(2,4), Is.EqualTo(6));
        }

        [Test]
        public void Subtraction_Subtract6And6()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtraction(6,6), Is.EqualTo(0));
        }

        [Test]
        public void Multiplication_Multiply4And4()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiplication(4,4), Is.EqualTo(16));
        }

        [Test]
        public void Division_Divide60And10()
        {
            var uut = new Calculator();
            Assert.That(uut.Division(50,10), Is.EqualTo(5));
        }


        [Test]
        public void NumberSquared_4to2()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(4), Is.EqualTo(16));
        }
        [Test]
        public void Divide_FourAndNull()
        {
            var uut = new Calculator();
            try
            {
                Assert.That(uut.Divide(4, 0), Is.EqualTo(0));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ooopps, something went wrong... You are dividing by zero");
            }

        }
    }
}

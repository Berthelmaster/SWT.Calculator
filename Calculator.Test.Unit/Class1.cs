using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.That(uut.Multiplication(4,4), Is.EqualTo(60));
        }

        [Test]
        public void Division_Divide60And10()
        {
            var uut = new Calculator();
            Assert.That(uut.Division(60,10), Is.EqualTo(6));
        }
    }
}

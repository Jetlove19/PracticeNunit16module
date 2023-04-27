using NUnit.Framework;
using PracticeNunit16module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNuint16module.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustAddNumbers()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        [Test]
        public void SubtractionMustMinusNumbers()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(50,100) == -50);
        }

        [Test]
        public void MultiMustMultCorrect()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(4, 3) == 12);
        }
        [Test]
        public void DivideMustDivideCorrectNumbers() 
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(100, 10) == 10);
        }
    }
}

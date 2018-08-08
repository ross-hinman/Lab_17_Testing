using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab_17_Testing;

namespace Primes.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void False_If_Number_Is_Less_Than_0()
        {
            //arrange
            var generator = new PrimeNumberValidator();

            //act

            var result = generator.IsPrime(-1);           
           
            //assert
            Assert.IsFalse(result);
           
        }
        [Test]
        public void False_If_Number_Is_0()
        {
            //arrange
            var generator = new PrimeNumberValidator();

            //act

            var result = generator.IsPrime(0);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void False_If_Number_Is_1()
        {
            //arrange
            var generator = new PrimeNumberValidator();

            //act

            var result = generator.IsPrime(1);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void False_If_Number_Is_Even()
        {
            //arrange
            var generator = new PrimeNumberValidator();

            //act
            var result = generator.IsPrime(4);

            //assert
            Assert.IsFalse(result);

        }
        [Test]
        public void False_If_Number_Is_Not_Divisible_By_Any_Number_But_Itself_Or_1()
        {
            //arrange
            var generator = new PrimeNumberValidator();

            //act
            var result = generator.IsPrime(9);
            //assert
            Assert.IsFalse(result);

        }
    }
}

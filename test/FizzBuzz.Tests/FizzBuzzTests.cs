using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Test]
        public void ShouldOutputNumbers()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(Enumerable.Range(1, 2));

            Assert.AreEqual("1 2", result);
        }

        [Test]
        public void ShouldOutputFizzForMultiplesOfThree()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(new[] {6, 9});

            Assert.AreEqual("fizz fizz", result);
        }

        [Test]
        public void ShouldOutputBuzzForMultiplesOfFive()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(new[] { 5, 10 });

            Assert.AreEqual("buzz buzz", result);
        }

        [Test]
        public void ShouldOutputFizzBuzzForMultiplesOfFithteen()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(new[] { 15, 45 });

            Assert.AreEqual("fizzbuzz fizzbuzz", result);
        }

        [Test]
        public void ShouldOutputLucky()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(new[] { 3, 13, 23, 33 });

            Assert.AreEqual("lucky lucky lucky lucky", result);
        }

        [Test]
        public void EndToEnd()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(Enumerable.Range(1, 20));

            Assert.AreEqual("1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz", result);
        }

        [Test]
        public void EndToEndStats()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.PrintOutputAndStats(Enumerable.Range(1, 20));

            var expectedResult = @"1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz
fizz: 4
buzz: 3
fizzbuzz: 1
lucky: 2
integer: 10";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldPrintNothingWhenNullInput()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(null);

            Assert.AreEqual(string.Empty, result);
        }
    }
}

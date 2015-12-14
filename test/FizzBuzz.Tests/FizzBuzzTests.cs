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
            var result = sut.Print(new[] {3, 6, 9});

            Assert.AreEqual("fizz fizz fizz", result);
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
            var result = sut.Print(new[] { 15, 30 });

            Assert.AreEqual("fizzbuzz fizzbuzz", result);
        }

        [Test]
        public void EndToEndTest()
        {
            var sut = new FizzBuzzPrinter();
            var result = sut.Print(Enumerable.Range(1, 20));

            Assert.AreEqual("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        public string Print(IEnumerable<int> range)
        {
            if (range == null)
            {
                return string.Empty;
            }

            return GetOutputAndStats(range).Output.TrimStart();
        }

        public string PrintOutputAndStats(IEnumerable<int> range)
        {
            if (range == null)
            {
                return string.Empty;
            }

            var result = GetOutputAndStats(range);
            return string.Format("{1}{0}fizz: {2}{0}buzz: {3}{0}fizzbuzz: {4}{0}lucky: {5}{0}integer: {6}",
                Environment.NewLine,
                result.Output.TrimStart(),
                result.FizzCount,
                result.BuzzCount,
                result.FizzBuzzCount,
                result.LuckyCount,
                result.IntegerCount
                );
        }

        private PrintResult GetOutputAndStats(IEnumerable<int> range)
        {
            return range.Select(x =>
                        {
                            if (IsLucky(x))
                            {
                                return "lucky";
                            }

                            if (IsMultiple(x, 15))
                            {
                                return "fizzbuzz";
                            }

                            if (IsMultiple(x, 3))
                            {
                                return "fizz";
                            }

                            if (IsMultiple(x, 5))
                            {
                                return "buzz";
                            }

                            return x.ToString();
                        })
                        .Aggregate<string, PrintResult>(new PrintResult(),
                            (current, next) =>
                            {
                                switch (next)
                                {
                                    case "fizz":
                                        current.FizzCount++;
                                        break;
                                    case "buzz":
                                        current.BuzzCount++;
                                        break;
                                    case "fizzbuzz":
                                        current.FizzBuzzCount++;
                                        break;
                                    case "lucky":
                                        current.LuckyCount++;
                                        break;
                                    default:
                                        current.IntegerCount++;
                                        break;
                                }
                                current.Output += " " + next;
                                return current;
                            });
        }

        private bool IsLucky(int x)
        {
            return NumberContainsDigit(x, 3);
        }

        private bool IsMultiple(int x, int y)
        {
            return x % y == 0;
        }

        private bool NumberContainsDigit(int number, int digit)
        {
            number = Math.Abs(number);
            while (number != 0)
            {
                var lastDigit = number % 10;
                if (lastDigit == digit)
                {
                    return true;
                }
                number = number / 10;
            }

            return false;
        }
    }

    public class PrintResult
    {
        public string Output { get; set; }

        public int FizzCount { get; set; }
        public int BuzzCount { get; set; }
        public int FizzBuzzCount { get; set; }
        public int LuckyCount { get; set; }
        public int IntegerCount { get; set; }
    }
}

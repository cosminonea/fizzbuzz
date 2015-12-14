using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        public string Print(IEnumerable<int> range)
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
                        .Aggregate((current, next) => current + " " + next);
        }

        private bool IsLucky(int x)
        {
            return x.ToString().Contains("3");
        }

        private bool IsMultiple(int x, int y)
        {
            return x % y == 0;
        }
    }
}

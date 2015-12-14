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

        private bool IsMultiple(int x, int y)
        {
            return x % y == 0;
        }
    }
}

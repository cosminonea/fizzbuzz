using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        public string Print(IEnumerable<int> range)
        {
            return range.Select(x => x.ToString())
                        .Aggregate((current, next) => current + " " + next);
        }
    }
}
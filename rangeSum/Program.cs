using System;
using System.Collections.Generic;
using System.Linq;

namespace rangeSum
{
  class Program
  {
    public static int GetSum(int a, int b)
    {
      int firstParam = Math.Min(a, b);
      int lastParam = Math.Max(a, b);
      int range = lastParam - firstParam + 1;
      IEnumerable<int> seq = Enumerable.Range(firstParam, range);
      return seq.Aggregate(0, (acc, x) => acc + x);
    }
    static void Main(string[] args)
    {
      Console.WriteLine($"sum of range 0-2: {GetSum(8, 2)}");
    }
  }
}


namespace tenMinutesWalk
{
  using System;
  using Solution;
  using System.Linq;
  class Program
  {
    public static bool IsValidWalk(string[] walk)
    {
      Array.ForEach(walk, x => Console.Write($"{x} "));
      if (walk.Length != 10) return false;
      var culture = new System.Globalization.CultureInfo("en-US");
      System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
      string[] input = walk.Select(elm => elm
          .Replace("n", "1")
          .Replace("s", "-1")
          .Replace("w", "0.33")
          .Replace("e", "-0.33")
      ).ToArray();
      return input.Aggregate(0.0, (acc, elm) =>
      {
        // Console.WriteLine($"acc: {acc}, elm: {Convert.ToDouble(elm)}");
        return acc + Double.Parse(elm);
      }) == 0.0;
    }
    static void Main(string[] args)
    {
      SolutionTest tests = new SolutionTest();
      tests.SampleTest();
    }
  }
}

namespace Solution
{
  using tenMinutesWalk;
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      // Assert.AreEqual(true, Program.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
      Assert.AreEqual(false, Program.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
      Assert.AreEqual(false, Program.IsValidWalk(new string[] { "w" }), "should return false");
      Assert.AreEqual(false, Program.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
    }
  }
}
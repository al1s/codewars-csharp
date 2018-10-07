
namespace Kata
{
  using System.Collections.Generic;
  using System.Linq;
  using Solution;
  class Program
  {
    // https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp
    public static string FirstNonRepeatingLetter(string s)
    {
      Dictionary<char, int> charFreq = s
        .GroupBy(ch => char.ToUpperInvariant(ch))
        .ToDictionary(grp => grp.Key, grp => grp.Count());
      foreach (char ch in s)
      {
        if (charFreq[char.ToUpperInvariant(ch)] == 1) return ch.ToString();
      }
      return "";
    }
    static void Main(string[] args)
    {
      KataTest tests = new KataTest();
      tests.BasicTests();
    }
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;
  using Kata;

  [TestFixture]
  public class KataTest
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("a", Program.FirstNonRepeatingLetter("a"));
      Assert.AreEqual("t", Program.FirstNonRepeatingLetter("stress"));
      Assert.AreEqual("e", Program.FirstNonRepeatingLetter("moonmen"));
    }
  }
}
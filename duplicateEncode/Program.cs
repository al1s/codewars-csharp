namespace codeWarsTraining
{
  using System;
  using System.Linq;
  using System.Collections.Generic;
  using Solution;

  class Program
  {
    public static string DuplicateEncode(string word)
    {
      string result = "";
      string inputStr = word.ToUpper();
      Dictionary<char, int> seq = inputStr
        .GroupBy(c => c)
        .Select(c => new { Char = c.Key, Count = c.Count() })
        .ToDictionary(d => d.Char, d => d.Count);
      inputStr.ToList().ForEach(elm => result += seq[elm] > 1 ? ")" : "(");
      return result;
    }
    static void Main(string[] args)
    {
      // Console.WriteLine(DuplicateEncode("recede"));
      KataTests tests = new KataTests();
      tests.BasicTests();
    }
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;
  using codeWarsTraining;

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("(((", Program.DuplicateEncode("din"));
      Assert.AreEqual("()()()", Program.DuplicateEncode("recede"));
      Assert.AreEqual(")())())", Program.DuplicateEncode("Success"), "should ignore case");
      Assert.AreEqual("))((", Program.DuplicateEncode("(( @"));
    }
  }
}
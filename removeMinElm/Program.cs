namespace removeMinElm
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using KataTests;
  public class Remover
  {
    public static List<int> RemoveSmallest(List<int> numbers)
    {
      // Good Luck!
      if (numbers.Count() == 0) return numbers;
      List<int> result = new List<int>(numbers);
      result.RemoveAt(result.IndexOf(result.Min()));
      return result;
    }
    static void Main(string[] args)
    {
      RemoveSmallestTests.BasicTests();
      List<int> input = new List<int>(new int[] { 2, 3, 4, 5, 6, 3 });
      Console.Write("Input before: ");
      input.ForEach(i => Console.Write($"{i} "));
      Console.Write("\nResult: ");
      List<int> result = RemoveSmallest(input);
      result.ForEach(i => Console.Write($"{i} "));
      Console.Write("\nInput after: ");
      input.ForEach(i => Console.Write($"{i} "));
    }
  }
}

namespace KataTests
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using NUnit.Framework;
  using removeMinElm;

  [TestFixture]
  public class RemoveSmallestTests
  {
    private static void Tester(List<int> argument, List<int> expectedResult)
    {
      CollectionAssert.AreEqual(expectedResult, Remover.RemoveSmallest(argument));
    }
    [Test]
    public static void BasicTests()
    {
      Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
      Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
      Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
      Tester(new List<int>(), new List<int>());
    }
  }
}
namespace validBraces
{
  using System;
  using System.Linq;
  using System.Collections.Generic;
  using Solution;


  public class Brace
  {
    public static bool validBraces(String braces)
    {
      Stack<char> stack = new Stack<char>();
      foreach (char item in braces)
      {
        if ("[{(<".Contains(item))
        {
          char itemToStack = default(char);
          switch (item)
          {
            case '[':
              itemToStack = ']';
              break;
            case '{':
              itemToStack = '}';
              break;
            case '(':
              itemToStack = ')';
              break;
            case '<':
              itemToStack = '>';
              break;
          }
          stack.Push(itemToStack);
        }
        if (")}]>".Contains(item))
        {
          if (stack.Count == 0) return false;
          char itemInStack = stack.Pop();
          if (itemInStack != item) return false;
        }
      }
      if (stack.Count != 0) return false;
      return true;
    }
    static void Main(string[] args)
    {
      BraceTests tests = new BraceTests();
      tests.Test1();
      tests.Test2();
    }
  }
}

namespace Solution
{
  using System;
  using System.Collections;
  using NUnit.Framework;
  using validBraces;

  [TestFixture]
  public class BraceTests
  {

    [Test]
    public void Test1()
    {
      Assert.AreEqual(true, Brace.validBraces("()"));
    }
    [Test]
    public void Test2()
    {

      Assert.AreEqual(false, Brace.validBraces("[(])"));
    }
  }
}
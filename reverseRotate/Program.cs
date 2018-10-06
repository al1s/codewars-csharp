namespace Program
{
  using System;
  using System.Linq;
  using Tests;

  public class Revrot
  {
    public static string RevRot(string strng, int sz)
    {
      string result = default(string);
      if (strng.Length < sz || sz <= 0 || strng.Length == 0) return "";
      for (int i = 0; i < strng.Length / sz; i++)
      {
        string chunk = strng.Substring(i * sz, sz);
        Console.WriteLine(chunk);
        int chunkSumCubes = chunk
          .Sum(c => (int)Math.Pow(int.Parse(c.ToString()), 3));
        if (chunkSumCubes % 2 == 0)
        {
          Console.WriteLine("Reversing input");
          result += new string(chunk.Reverse().ToArray());
        }
        else
        {
          Console.WriteLine("Rotating input");
          result += chunk.Substring(1) + chunk[0];
        }
      }
      return result;
    }
    public static void Main()
    {
      Tests.test1();
    }
  }
}


namespace Tests
{

  using System;
  using NUnit.Framework;
  using Program;
  public class Tests
  {
    private static void testing(string actual, string expected)
    {
      Assert.AreEqual(expected, actual);
    }

    public static void test1()
    {
      Console.WriteLine("Testing RevRot");
      // testing(Revrot.RevRot("1234", 0), "");
      // testing(Revrot.RevRot("", 0), "");
      // testing(Revrot.RevRot("1234", 5), "");
      String s = "733049910872815764";
      testing(Revrot.RevRot(s, 5), "330479108928157");
    }
  }
}
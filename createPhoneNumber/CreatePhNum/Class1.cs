using System;
using System.Linq;

namespace CreatePhNum
{
  public class Class1
  {
    private static string concatIntoPhoneNumber(int num)
    {
      return default(String);
    }
    public static string CreatePhoneNumber(int[] numbers)
    {
      string acc = "(";
      for (int i = 0; i < numbers.Count(); i++)
      {
        switch (i)
        {
          case 3:
            acc = String.Concat(acc, ") ", numbers[i]);
            // acc = "{acc}) {numbers[i]}";
            break;
          case 6:
            acc = String.Concat(acc, "-", numbers[i]);
            // acc = "{acc}-{numbers[i]}";
            break;
          default:
            acc = String.Concat(acc, numbers[i]);
            // acc = "{acc}${numbers[i]}";
            break;
        }
      }
      // String.Concat(acc, numbers[i]);
      //  Aggregate("(", (acc, elm, ndx) =>
      return acc;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(Class1.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
    }
  }
}

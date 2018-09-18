using System;
using System.Text.RegularExpressions;

namespace Calculator
{
  class Program
  {
    private static int Add(int a, int b) => a + b;
    private static int Subtract(int a, int b) => a - b;
    private static int Multiply(int a, int b) => a * b;
    private static int Divide(int a, int b) => a / b;
    delegate int CalculateMethod(int firstParam, int secondParam);

    static void Main(string[] args)
    {
      int a;
      int b;
      int result = 0;
      CalculateMethod calc = null;
      Console.WriteLine("Enter a simple arithmetic expression (two parameters)");
      string task = Console.ReadLine();
      //   string task = "1+2";
      string pattern = @"\s*([0-9]+)\s*([+\-*\/])+\s*([0-9]+)\s*";
      Match match = Regex.Match(task, pattern);
      bool parsedFirst = Int32.TryParse(match.Groups[1].Value, out a);
      bool parsedSecond = Int32.TryParse(match.Groups[3].Value, out b);
      if (parsedFirst && parsedSecond)
      {
        string action = match.Groups[2].Value;
        switch (action)
        {
          case "+":
            calc = Add;
            break;
          case "-":
            calc = Subtract;
            break;
          case "*":
            calc = Multiply;
            break;
          case "/":
            calc = Divide;
            break;

        }
        result = calc(a, b);
        Console.WriteLine($"{a} {action} {b} = {result}");
      }
    }
  }
}

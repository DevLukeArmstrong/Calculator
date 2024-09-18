// This project is going to be a simple console calculator
// See https://aka.ms/new-console-template for more information 

// Take in console arguments as int string int
//Create method that does the calculation and returns
using System;

namespace Calculator
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      int x = Int32.Parse(args[0]);
      string op = args[1];
      int y = Int32.Parse(args[2]);

      int result = Calculate(x, op, y);

      Console.WriteLine(result);
    }

    private static int Calculate(int x, string op, int y)
    {
      switch (op)
      {
        case "+": return x + y;
        case "-": return x - y;
        case "*": return x * y;
        case "/": return x / y;
        case "%": return x % y;
        default: throw new Exception("Invalid operation");
      }
    }
  }

}
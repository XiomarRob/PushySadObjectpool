using System;
using Microsoft.VisualBasic;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************\n");
  }

  static int getInput (string prompt)
  {
    int result;
    Console.Write(prompt);
    while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
    {
      Console.Write("Invalid input. Enter a positive valid number: ")
    }
    return result;
  }

  static void Revenue()
  {
    Console.WriteLine("")
  }
}
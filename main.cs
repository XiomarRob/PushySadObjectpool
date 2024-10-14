using System;

class Program {
  public static void Main (string[] args) {
           string[] salespersonNames = { "D", "E", "F" };
    char[] allowedInitials = { 'D', 'E', 'F'};
    double totalD = 0, totalE =0, totalF = 0, saleAmount;
    char spInitial;
    string input;

    while (true)
    { 
        Console.Write("Enter salesperson initial (D, E, or  F) or Z to quit: ");
        input = Console.ReadLine();
        spInitial = char.ToUpper(input[0]);

        if (spInitial == 'Z') break;

        int index = Array.IndexOf(allowedInitials, spInitial); 

        if (index == -1)
        {
          Console.WriteLine("Error, invalid salesperson selected, please try again.");
          continue;
        }

        Console.Write("Enter sales number: ");
        if (!double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount < 0)
        {
          Console.WriteLine("Sale amount invalid, Please enter the valid sale amount");
          continue;
        }
        switch (spInitial)
        {
          case 'D':
            totalD += saleAmount;
            break;
          case 'E':
            totalE += saleAmount;
            break;
          case 'F':
            totalF += saleAmount;
            break;
        }
        double ovrTotal = totalD + totalE + totalF;

        string highestSalesperon = "D";
        double largestTotal = totalD;

        if (totalE > largestTotal)
        {
          largestTotal = totalE;
          highestSalesperon = "E";
        }
        if (totalF > largestTotal)
        {
          largestTotal = totalF;
          highestSalesperon = "F";
        }

        Console.WriteLine("\nSales Summary:");

        Console.WriteLine("Grand Total:{0:C}", ovrTotal);
        Console.WriteLine("Highest Sale: {0}", highestSalesperon);


    }
  }
}
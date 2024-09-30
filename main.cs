using System;

class Program {
  public static void Main (string[] args) {
    double totalD = 0, totalE =0, totalF = 0, saleAmount;
    char spInitial;
    string input;

    while (true)
    {
        Console.Write("Enter salesperson initial (D, E, or  F) or Z to quit: ");
        input = Console.ReadLine();
        spInitial = char.ToUpper(input[0]);

        if (spInitial == 'Z') break;

        if (spInitial != 'D' && spInitial != 'E' && spInitial != 'F' )
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
        Console.WriteLine("Total sales by D: {0:C}", totalD);
        Console.WriteLine("Total sales by E: {0:C}", totalE);
        Console.WriteLine("Total sales by F: {0:C}", totalF);
        Console.WriteLine("Grand Total:{0:C}", ovrTotal);
        Console.WriteLine("Highest Sale: {0}", highestSalesperon);


    }
  }
}
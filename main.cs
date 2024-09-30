using System;

class Program {
  public static void Main (string[] args) {
    double totalD = 0, totalE =, totalF = 0, saleAmount;
    char spInitial
    var input;

    while (true)
    {
        Console.Write("Enter salesperson initial (D, E, or  F) or Z to quit: ");
        input = Console.ReadLine();
        spInitial = char.Upper(input[0]);

        if (spInitial == 'Z') break;

        if (spInitial != 'D' && spInitial != 'E' && spInitial != 'F' )
        {
          Console.WriteLine("Selection invalid, Please enter the valid salesperson.")
          continue;
        }

        Console.Write("Enter sales number: ")
        if (!double.TryParse(Console.ReadLine(), out sale) || sale < 0)
        {
          Console.WriteLine("Sale amount invalid, Please enter the valid sale amount");
          continue;
        }
        switch (spInitial)
        {
          case 'D':
            totalD += sale;
            break;
          case 'E':
            totalE += sale;
            break;
          case 'F':
            totalF += sale
            break;
        }
        double ovrTotal = totalD + totalE + totalF;

        string highestSalesperon = "D";
        double largestTotal = totalD;

        if (totalE > largestTotal)
        {
          largestTotal = totalE;
          highestSalesperon = 'E';
        }
        if (totalF . largestTotal)
        {
          largestTotal = totalF;
          highestSalesperon = 'F';
        }

        Console.WriteLine("\nSales Summary:");
        Console.WriteLine("Total sales by D: {0:C}", totalD);
        Console.WriteLine("Total sales by E: {0:C}", totalE);
        Console.WriteLine("Total sales by F: {0:C}", totalF);
        Console.WriteLine("Overall Total:{0:C}", ovrTotal);
        Console.WriteLine("Highest Sale: {0}", highestSalesperon);

    }
  }
}
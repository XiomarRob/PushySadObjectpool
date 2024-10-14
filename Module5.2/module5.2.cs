using System;

class Program {
  public static void Main (string[] args) {
    const int numTemps = 5;
    const int minTemp = -30;
    const int maxTemp = 130;
    int[] temperatures = new int[numTemps];
    int temp;

    for (int i = 0; i < numTemps; i++)
    {
        while (true)
        {
            try
            {
                Console.Write($"Enter temperature {i + 1}; ");
                temp = int.Parse(Console.ReadLine());
                if (temp < minTemp )
            }
        }
    }
  }
}

using System;

class Program {
  public static void Main (string[] args) {
    const int numTemps = 5;
    const int minTemp = -30;
    const int maxTemp = 130;
    int[] temperatures = new int[numTemps];
    int temp;
    string? input;

    for (int i = 0; i < numTemps; i++)
    {
        while (true)
        {
                Console.Write($"Enter temperature {i + 1}: ");
                input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine($"Error: No input provided. Please enter a valid temperature.");
                    continue;
                    }
                    try
                    {
                    temp = int.Parse(input); 
                    
                    if (temp < minTemp || temp > maxTemp)
                    {
                    throw new Exception($"Temperature {temp} is invalid. Please enter a valid temperature between {minTemp} and {maxTemp}.");
                    }
                    temperatures[i] = temp;
                    break;
                
                }
                    catch (FormatException)
                    {
                        Console.WriteLine("check expected outcome");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            
    bool gettingWarmer = true;
    bool gettingCooler = true;
    {
    for (int i = 1; i < numTemps; i++)
    {
        if (temperatures[i] < temperatures[i-1])
            gettingWarmer = false;
        if (temperatures[i] > temperatures[i-1])
            gettingCooler = false;
        
    }
    if (gettingWarmer)
    {
        Console.WriteLine("Getting Warmer");
    }
    else if (gettingCooler)
    {
        Console.WriteLine("Getting Cooler");
    }
    else
    {
        Console.WriteLine("It's a mixed bag");
    }
    Console.WriteLine("5-day Temperatures: [" + string.Join(", ", temperatures) + "]");
    double averageTemp = temperatures.Average();
    Console.WriteLine($"Average Temperature is {averageTemp:F1} degrees");
  }
  }
  }

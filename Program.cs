
using System;
using System.Runtime.CompilerServices;

class Program
{
  static void Main(string[] args)
  {
    PreMenu();
  }

  static void PreMenu()
  {
    Console.Clear();
    Console.WriteLine("Hello, welcome to the timer!");
    Thread.Sleep(3000);
    Console.Clear();
    Console.WriteLine(@"What to you do?
0 - Exit
1 - To count!");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
      case 0:
        Console.Clear();
        Console.WriteLine("Goodbye!");
        Thread.Sleep(1000);
        Console.Clear();
        System.Environment.Exit(0);
        break;
      case 1:
        Menu();
        break;
      default:
        Console.WriteLine("Invalid option!");
        Thread.Sleep(1000);
        PreMenu();
        break;
    }
  }

  static void Menu()
  {
    Console.Clear();
    Console.WriteLine(@"How long do you want to count?
- Seconds = s ==> 5s = 5 Seconds
- Minutes = m ==> 1m = 1 Minute
    ");
    string option = Console.ReadLine().ToLower();
    char type = char.Parse(option.Substring(option.Length - 1, 1));
    int time = int.Parse(option.Substring(0, option.Length - 1));
    int multiplier = 1;
    if (type == 'm')
    {
      multiplier = 60;
    }
    if (time == 0)
    {
      System.Environment.Exit(0);
    }
    PreStart(time * multiplier);
  }

  static void PreStart(int time)
  {
    Console.Clear();
    Console.WriteLine("Ready ...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set ...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Go!");
    Thread.Sleep(2000);
    Console.Clear();
    Start(time);
  }

  static void Start(int time)
  {
    int currentTime = 0;

    for (int i = 0; i < time; i++)
    {
      currentTime++;
      Console.Clear();
      Console.WriteLine($"{currentTime}s");
      Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Stopwatch finished!");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("To back to the menu, press any key!");
    Console.ReadKey();
    Thread.Sleep(1000);

    PreMenu();
  }


}
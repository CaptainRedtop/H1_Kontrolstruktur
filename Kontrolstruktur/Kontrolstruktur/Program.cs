using System.Data;

namespace Kontrolstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Terning";

            while (true)
            {
                Console.WriteLine("\nPress Enter to roll dice or any other key to exit\n");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Random random = new Random();
                    int dice = random.Next(1, 7);

                    if (dice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Din terningkast er: 1\n");
                    }
                    else if (dice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Din terningkast er: 2\n");
                    }
                    else if (dice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Din terningkast er: 3\n");
                    }
                    else if (dice == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Din terningkast er: 4\n");
                    }
                    else if (dice == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Din terningkast er: 5\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Din terningkast er: 6\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
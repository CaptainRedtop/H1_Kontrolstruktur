namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI";

            while (true)
            {
                //User input
                Console.Write("Enter your height in meter (m): ");
                float height = float.Parse(Console.ReadLine());
                Console.Write("\nEnter your weight in kilos (kg): ");
                float weight = float.Parse(Console.ReadLine());

                //Calculations
                float bmi = weight / (height * height);

                //Output
                if (bmi < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"\nYour BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Body Weight Deficit");
                }
                else if (bmi < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Your BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Norm");
                }
                else if (bmi < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Weight Over");
                }
                else if (bmi < 35)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Your BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Obeesity first degree");
                }
                else if (bmi < 40)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Your BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Obeesity second degree");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your BMI is {bmi.ToString("0.0")}");
                    Console.WriteLine("which means: Body third Deficit");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nPress Enter to continue or Esc to exit");
                var key = Console.ReadKey();
                Console.Clear();
                if (key.Key != ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
    }
}
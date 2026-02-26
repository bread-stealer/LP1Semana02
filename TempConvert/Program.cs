using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
           // Create a program that asks for input of a temperature and origin unity
           // "C" for Celsius ou "F" for Fahrenheit
           // Using switch, the program converts a temperature for another unity and
           // presents the result with 2 decimal houses; The output should print the received value
           // and the converted values: Examples( -40.00F = -40.00C)
           // Formula: F = C x 1.8 + 32 e C = (F - 32)/1.8
           // 
           // Additionally, the program presents the absolute value in converted temperature. If the unity inputted
           // is not "C" or "F", the program prints "Invalid unity."

            Console.WriteLine("Temperature:");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unity (C/F):");
            string unity = Console.ReadLine().ToUpper();

            switch (unity)
            {
                case "C":
                    double fahrenheit = temp * 1.8 + 32;
                    Console.WriteLine($"{temp:F2} C = {fahrenheit:F2} F");
                    Console.WriteLine($"Absolute value: {Math.Abs(fahrenheit):F2}F");
                    break;
                case "F":
                    double celsius = (temp - 32) / 1.8;
                    Console.WriteLine($"{temp:F2}F = {celsius:F2}C");
                    Console.WriteLine($"Absolute value: {Math.Abs(celsius):F2}C");
                    break;
            }

        }
    }
}

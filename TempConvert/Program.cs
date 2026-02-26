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
           // presents the result with 2 decimal houses;
           // Formula: F = C x 1.8 + 32 e C = (F - 32)/1.8
           // Additionally, the program presents the absolute value in converted temperature. If the unity inputted
           // is not "C" or "F", the program prints "Invalid unity."

            Console.WriteLine("Temperature:");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unity (C/F):");
            string unity = Console.ReadLine().ToUpper();
        }
    }
}

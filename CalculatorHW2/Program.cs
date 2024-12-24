using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in my calculator");
            Console.Write("Enter value for First Number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for Secound Number: ");
            double secoundNumber = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = new Calculator(firstNumber,secoundNumber);
            Console.WriteLine($"The Sum For ({calculator.GetFirstNumber()} + {calculator.GetSecoundNumber()}) = {calculator.Add()}");
            Console.WriteLine($"The Subtraction For({calculator.GetFirstNumber()} - {calculator.GetSecoundNumber()}) = {calculator.Subtract()}");
            Console.WriteLine($"The Multiplaction For ({calculator.GetFirstNumber()} * {calculator.GetSecoundNumber()}) = {calculator.Multiply()}");
            Console.WriteLine($"The Diviation For ({calculator.GetFirstNumber()} / {calculator.GetSecoundNumber()}) = {calculator.Divied()}");

        }
    }
}

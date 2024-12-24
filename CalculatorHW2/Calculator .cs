using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHW2
{
    internal class Calculator
    {
        // properties
        private double firstNumber;
        private double secoundNumber;
        
        // Constructor  
        public Calculator(double x, double y)
        {
            this.firstNumber = x;
            this.secoundNumber = y;
        }
        public Calculator() 
        { 
            this.firstNumber = 0;
            this.secoundNumber = 0;
        }
        public double Add() 
        { 
            return this.firstNumber + this.secoundNumber;
        }
        public double Subtract()
        {
            return this.firstNumber - this.secoundNumber;
        }
        public double Multiply()
        {
            return this.firstNumber * this.secoundNumber;
        }
        public string Divied()
        {
            if (this.secoundNumber == 0)
            {

                return "We can\'t Divied by 0 ";

            }
            else 
            {
                return (this.firstNumber / this.secoundNumber).ToString();    
            }
        }
        // Getter and Setter for x
        public double GetFirstNumber()
        {
            return this.firstNumber;
        }

        public void SetFirstNumber(double value)
        {
            this.firstNumber = value;
        }

        // Getter and Setter for y
        public double GetSecoundNumber()
        {
            return this.secoundNumber;
        }

        public void SetY(double value)
        {
            this.secoundNumber = value;
        }

    }
}

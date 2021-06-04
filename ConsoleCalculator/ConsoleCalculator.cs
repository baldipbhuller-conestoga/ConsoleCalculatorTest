using System;

namespace ConsoleCalculator
{
    // Baldip Singh Bhuller

    public class ConsoleCalculator
    {
        private decimal firstNumber;
        private decimal secondNumber;

        public ConsoleCalculator()
        {
            FirstNumber = 1;
            SecondNumber = 1;
        }

        public decimal FirstNumber { get => firstNumber; set => firstNumber = value; }
        public decimal SecondNumber { get => secondNumber; set => secondNumber = value; }

        // Addition method rounded to 3 decimal places
        public decimal Addition(decimal firstNumber, decimal secondNumber)
        {
            return Math.Round(firstNumber + secondNumber, 3);
        }

        // Subtraction method rounded to 3 decimal places
        public decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {
            return Math.Round(firstNumber - secondNumber, 3);
        }

        // Multiplication method rounded to 3 decimal places
        public decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            return Math.Round(firstNumber * secondNumber, 3);
        }

        // Division method rounded to 3 decimal places
        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            return Math.Round(firstNumber / secondNumber, 3);
        }

        public static void RunConsoleView()
        {
            string operationInput, firstNumber, secondNumber;
            decimal result;

            Console.WriteLine("Console Calculator");
            Console.Write("Choose operation: \n" +
                           "+ for Addition \n" +
                           "- for Subtraction \n" +
                           "* for Multiplication \n" +
                           "/ for Division \n" +
                           "Type input here:" );

            //Get input operation
            operationInput = Console.ReadLine();

            ConsoleCalculator consoleCalculator = new ConsoleCalculator();

            //Get input first number
            Console.Write("Enter first number:");
            firstNumber = Console.ReadLine();
            consoleCalculator.FirstNumber = decimal.Parse(firstNumber);

            //Get input second number
            Console.Write("Enter second number:");
            secondNumber = Console.ReadLine();
            consoleCalculator.SecondNumber = decimal.Parse(secondNumber);

            //Check operation
            switch (operationInput)
            {
                case "+": 
                    result = consoleCalculator.Addition(consoleCalculator.FirstNumber, consoleCalculator.SecondNumber);
                    break;
                case "-":
                    result = consoleCalculator.Subtraction(consoleCalculator.FirstNumber, consoleCalculator.SecondNumber);
                    break;
                case "*":
                    result = consoleCalculator.Multiplication(consoleCalculator.FirstNumber, consoleCalculator.SecondNumber);
                    break;
                case "/":
                    result = consoleCalculator.Division(consoleCalculator.FirstNumber, consoleCalculator.SecondNumber);
                    break;
                default:
                    Console.WriteLine("Incorrect operation input");
                    result = 0;
                    break;
            }

            //Show result
            Console.Write("Result: {0}", result);
        }

        public static void Main(string[] args)
        {
            RunConsoleView();
        }
    }
}

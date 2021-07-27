using System;

namespace ConsoleCalculator
{
    // Baldip Singh Bhuller

    public class Calculator
    {
        private double firstNumber;
        private double secondNumber;

        public Calculator()
        {
            FirstNumber = 1;
            SecondNumber = 1;
        }

        public double FirstNumber { get => firstNumber; set => firstNumber = value; }
        public double SecondNumber { get => secondNumber; set => secondNumber = value; }

        // Addition method rounded to 3 decimal places
        public double Addition()
        {
            return Math.Round(FirstNumber + SecondNumber, 3);
        }

        // Subtraction method rounded to 3 decimal places
        public double Subtraction()
        {
            return Math.Round(FirstNumber - SecondNumber, 3);
        }

        // Multiplication method rounded to 3 decimal places
        public double Multiplication()
        {
            return Math.Round(FirstNumber * SecondNumber, 3);
        }

        // Division method rounded to 3 decimal places
        public double Division()
        {
            return Math.Round(FirstNumber * SecondNumber, 3);
        }

        public static void RunConsoleView()
        {
            string operationInput, firstNumber, secondNumber;
            double result;

            Console.WriteLine("Console Calculator");
            Console.Write("Choose operation: \n" +
                           "+ for Addition \n" +
                           "- for Subtraction \n" +
                           "* for Multiplication \n" +
                           "/ for Division \n" +
                           "Type input here:" );

            //Get input operation
            operationInput = Console.ReadLine();

            Calculator consoleCalculator = new Calculator();

            //Get and set input first number
            Console.Write("Enter first number:");
            firstNumber = Console.ReadLine();
            consoleCalculator.FirstNumber = double.Parse(firstNumber);

            //Get and set input second number
            Console.Write("Enter second number:");
            secondNumber = Console.ReadLine();
            consoleCalculator.SecondNumber = double.Parse(secondNumber);

            //Check operation
            switch (operationInput)
            {
                case "+": 
                    result = consoleCalculator.Addition();
                    break;
                case "-":
                    result = consoleCalculator.Subtraction();
                    break;
                case "*":
                    result = consoleCalculator.Multiplication();
                    break;
                case "/":
                    result = consoleCalculator.Division();
                    break;
                default:
                    Console.WriteLine("Incorrect operation input");
                    result = 0;
                    break;
            }

            //Show result
            Console.WriteLine("Result: {0}", result);
        }

        public static void Main(string[] args)
        {
            RunConsoleView();
        }
    }
}

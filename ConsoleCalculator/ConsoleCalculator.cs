using System;

namespace ConsoleCalculator
{
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

        public static void RunConsole()
        {
            string operationInput, firstNumber, secondNumber;

            Console.WriteLine("Console Calculator");
            Console.Write("Choose operation: \n" +
                           "+ for Addition \n" +
                           "- for Subtraction \n" +
                           "* for Multiplication \n" +
                           "/ for Division \n");

            operationInput = Console.ReadLine();

            ConsoleCalculator consoleCalculator = new ConsoleCalculator();

            Console.Write("Enter first number:");
            firstNumber = Console.ReadLine();
            consoleCalculator.FirstNumber = decimal.Parse(firstNumber);

            Console.Write("Enter second number:");
            secondNumber = Console.ReadLine();
            consoleCalculator.SecondNumber = decimal.Parse(secondNumber);

            Console.WriteLine("First number: {0}", consoleCalculator.FirstNumber);
            Console.WriteLine("Second number: {0}", consoleCalculator.SecondNumber);
        }

        public static void Main(string[] args)
        {
            RunConsole();
        }
    }
}

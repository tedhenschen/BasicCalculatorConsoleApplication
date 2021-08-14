using System;

namespace BasicCalculatorConsoleApplication.Classes
{
    class Calculator
    {
        public string Operator { get; set; }
        public int Num1;
        public int Num2;
        public int Result;

        public Calculator()
        {
            Run();
        }

        private void Run()
        {
            GetOperator();
            Console.WriteLine($"{Num1} {Operator} {Num2} = {Result}");
            ReRun();

        }



        private void GetOperator()
        {
            Console.WriteLine("Enter the type of calculation would you like to perform (+,-,*,/)");
            Operator = Console.ReadLine();
            OperatorCheck();
        }

        private void GetFirstNumber()
        { 
            string userInput;
            Console.WriteLine("Enter the first number in the caluclation");
            userInput = Console.ReadLine();
            //NumberCheck(userInput);
            if (NumberCheck(userInput))
            {
                Num1 = Int32.Parse(userInput);
                GetSecondNumber();
            }
            else
            {
                Console.WriteLine("That is not a number, please try again!");
                GetFirstNumber();
            }

        }

        private void GetSecondNumber()
        {
            string userInput;
            Console.WriteLine("Enter the second number in the caluclation");
            userInput = Console.ReadLine();
            //NumberCheck(userInput);
            if (NumberCheck(userInput))
            {
                Num2 = Int32.Parse(userInput);
                Result = Calculate();
            }
            else
            {
                Console.WriteLine("That is not a number, please try again!");
                GetSecondNumber();
            }

        }

        private int Calculate()
        {
            string myOperator = Operator;
            int myNum1 = Num1;
            int myNum2 = Num2;


            Calculations calc = new Calculations();
            calc.X = myNum1;
            calc.Y = myNum2;

            switch (myOperator)
            {
                case "+":
                    return calc.Add();
                case "-":
                    return calc.Subtract();
                case "*":
                    return calc.Multiply();
                case "/":
                    return calc.Divide();
                default:
                    Console.WriteLine("Something Broke... this should never happen");
                    return 0;
            }


        }

        private void ReRun()
        {
            Console.WriteLine("Do you want to run another calculation(y or n)");
            string prompt = Console.ReadLine();
            prompt = prompt.ToLower();
            if (prompt == "y")
            {
                Run();
            }
            else if (prompt == "n")
            {
                
            }
            else
            {
                Console.WriteLine("You have entered an invalid response, please try again");
            }

        }

        private void OperatorCheck()
        {
            if (Operator == "+" || Operator == "-" || Operator == "*" || Operator == "/" )
            {
                GetFirstNumber();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                GetOperator();
            }
        }

        private static bool NumberCheck(string numberCheck)
        {
            try
            {
                Int32.Parse(numberCheck);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}

using System;
using System.Net.WebSockets;
namespace Calculator
{
    class Program
    {
        public static void printOperations()
        {
            System.Console.WriteLine("Pick Operation Id");
            System.Console.WriteLine("1.Addition");
            System.Console.WriteLine("2.Subtraction");
            System.Console.WriteLine("3.Multiplication");
            System.Console.WriteLine("4.Division");
            System.Console.WriteLine("5.Sqrt");
            System.Console.WriteLine("6.Power");
            System.Console.WriteLine("7.Modulo");
            System.Console.WriteLine("00.exit");
        }
        public static string getInput(string message, string mode)
        {
            System.Console.WriteLine(message);
            string output = System.Console.ReadLine();
            if (mode == "operands")
            {
                output = output.Trim();
                while (output.Length == 0)
                {
                    System.Console.WriteLine(mode);
                    output = System.Console.ReadLine();
                    output = output.Trim();
                }
            }
            else if (mode == "Wrong Operand")
            {
                double a;
                while (!double.TryParse(output, out a))
                {
                    System.Console.WriteLine($"Please enter correct number instead of {output}");
                    output = System.Console.ReadLine();
                }
            }
            return output;
        }
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                printOperations();
                string choice = System.Console.ReadLine();
                if (choice.Length == 0) continue;
                if (choice == "00") break;
                string input = getInput("enter the two operands separated with space", "operands");
                int middle = input.Contains(" ") ? input.IndexOf(" ") : input.Length;
                string tempa = input.Substring(0, middle);
                string tempb = input.Contains(" ") ? input.Substring(middle, input.Length - middle) : "0";
                double a;
                double b;
                IOperation op;
                while (!double.TryParse(tempa, out a))
                {
                    System.Console.WriteLine($"Please enter correct number instead of {tempa}");
                    tempa = System.Console.ReadLine();
                }
                while (!double.TryParse(tempb, out b))
                {
                    System.Console.WriteLine($"Please enter correct number instead of {tempb}");
                    tempb = System.Console.ReadLine();
                }
                switch (choice)
                {
                    case "1":
                        op = new Addition();
                        System.Console.WriteLine(op.perform(a, b));
                        break;
                    case "2":
                        op = new Subtraction();
                        System.Console.WriteLine(op.perform(a, b));
                        break;
                    case "3":
                        op = new Multiplication();
                        System.Console.WriteLine(op.perform(a, b));
                        break;
                    case "4":
                        op = new Division();
                        if (b != 0)
                        {
                            System.Console.WriteLine(op.perform(a, b));
                        }
                        else
                        {
                            System.Console.WriteLine($"you tried to divide {a} by zero which is not acceptable");
                        }
                        break;
                    case "5":
                        op = new SquareRoot();
                        System.Console.WriteLine(op.perform(a));
                        break;
                    case "6":
                        op = new Power();
                        System.Console.WriteLine(op.perform(a, b));
                        break;
                    case "7":
                        op = new Modulo();
                        System.Console.WriteLine(op.perform(a, b));
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
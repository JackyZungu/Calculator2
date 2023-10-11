using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        double num1;
        double num2;
        string operat;
        //ConsoleKeyInfo status;
        double answer;

            while (true)
            {
                Console.Write("Please enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operat: (+, -, /, *): ");
                operat = Console.ReadLine();

                switch (operat)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operat + " " + num2.ToString() + " = " + answer.ToString());
                {
                   break;
                }
               Console.Clear();
            }
        }
    }
}

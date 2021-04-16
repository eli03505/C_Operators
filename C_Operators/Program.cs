using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Operators
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers: ");
            bool calculator = int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("Write Operator: ");

            bool calc = char.TryParse(Console.ReadLine(), out char Number);
            Console.WriteLine("Enter the second number: ");

            bool numbers = int.TryParse(Console.ReadLine(), out int num2);

            if (calculator && numbers && calc)
            {
                switch (Number)
                {
                    case '*':
                        {
                            Console.WriteLine(num * num2);
                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine(num / num2);
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine(num - num2);
                            break;
                        }
                    case '+':
                        {
                            Console.WriteLine(num + num2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid argument");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Invalid argument");
            }
        }
    }
}
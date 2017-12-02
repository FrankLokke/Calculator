using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Type First Number: ");
                string firstNumber = Console.ReadLine();
                double stringFirstNumber = Convert.ToDouble(firstNumber);
               
                Console.Write("Type Secund Number: ");
                string secundNumber = Console.ReadLine();
                double stringSecundNumber = Convert.ToDouble(secundNumber);

                Console.Write("Type the operation (+, -, *, /: ");
                string operation = Console.ReadLine();

                

                if (operation == "+")
                {
                    double print = stringSecundNumber + stringFirstNumber;
                    Console.Write("Your Result Is: " + print);
                    Console.ReadLine();
                    Console.Write("Do You Wanna Try Again?");
                    break;
                }
                else if (operation == "-")
                {
                    double print = stringSecundNumber - stringFirstNumber;
                    Console.Write("Your Result Is: " + print);
                    Console.ReadLine();
                    Console.Write("Hit 'Y' To Try Again, And 'N' To Tap Out: ");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (again == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid choice, try again:");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
                else if (operation == "*")
                {
                    double print = stringSecundNumber * stringFirstNumber;
                    Console.Write("Your Result Is: " + print);
                    Console.ReadLine();
                    Console.Write("Hit 'Y' To Try Again, And 'N' To Tap Out: ");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (again == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid choice, try again:");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                else if (operation == "/")
                {
                    double print = stringSecundNumber / stringFirstNumber;
                    Console.Write("Your Result Is: " + print);
                    Console.ReadLine();
                    Console.Write("Hit 'Y' To Try Again, And 'N' To Tap Out: ");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (again == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid choice, try again:");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Valid Operation, Try Again");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
        }
    }
}

//multiplikation *
//subtraktion - 
//addition +
//division /

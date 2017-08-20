using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo29
{
    interface IGenInterface<T>
    {
        T Add(T FirstNum, T SecondNum);
        T Subtract(T FirstNum, T SecondNum);
        T Multiply(T FirstNum, T SecondNum);
        T Divide(T FirstNum, T SecondNum);
    }
    class BasicMath<T> : IGenInterface<T>
    {
        public T Add(T FirstNum, T SecondNum)
        {
            dynamic numOne = FirstNum;
            dynamic numTwo = SecondNum;
            return numOne + numTwo;
        }

        public T Divide(T FirstNum, T SecondNum)
        {
            dynamic numOne = FirstNum;
            dynamic numTwo = SecondNum;
            return numOne / numTwo;
        }

        public T Multiply(T FirstNum, T SecondNum)
        {
            dynamic numOne = FirstNum;
            dynamic numTwo = SecondNum;
            return numOne * numTwo;
        }

        public T Subtract(T FirstNum, T SecondNum)
        {
            dynamic numOne = FirstNum;
            dynamic numTwo = SecondNum;
            return numOne - numTwo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                BasicMath<int> obj = new BasicMath<int>();
                string str = "YES";
                do
                {
                    if (str.ToUpper().Equals("YES") || str.ToUpper().Equals("Y"))
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------PERFORMING BASIC OPERATIONS-------------------------");
                        Console.WriteLine("\n1. Addition\n\n2. Subtraction\n\n3. Multiplication\n\n4. Division\n\nEnter your choice: \n\n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the first number: \n");
                                int FirstNumberOne = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number: \n");
                                int SecondNumberOne = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nThe sum of two numbers are " + obj.Add(FirstNumberOne, SecondNumberOne));
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the first number: \n");
                                int FirstNumberTwo = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number: \n");
                                int SecondNumberTwo = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nThe difference between two numbers are " + obj.Subtract(FirstNumberTwo, SecondNumberTwo));
                                break;
                            case 3:
                                Console.WriteLine("\nEnter the first number: \n");
                                int FirstNumberThree = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number: \n");
                                int SecondNumberThree = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nThe product of two numbers are " + obj.Multiply(FirstNumberThree, SecondNumberThree));
                                break;
                            case 4:
                                Console.WriteLine("\nEnter the first number: \n");
                                int FirstNumberFour = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number: \n");
                                int SecondNumberFour = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nThe division of two numbers are " + obj.Divide(FirstNumberFour, SecondNumberFour));
                                break;
                            default:
                                Console.WriteLine("\nInvalid Input!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input");
                    }
                    Console.WriteLine("\nDo you want to continue? (Yes/No)\n");
                    str = Console.ReadLine();
                } while (!str.ToUpper().Equals("NO") && !str.ToUpper().Equals("N"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

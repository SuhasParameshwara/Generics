using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo28
{
    class GenClass<T>
    {
        public virtual object add(T FirstNum, T SecondNum)
        {
            dynamic numOne = FirstNum;
            dynamic numTwo = SecondNum;
            return numOne + numTwo;
        }
    }
    class GenInt<T> : GenClass<T>
    {
        public object add(int FirstNum, int SecondNum)
        {
            return FirstNum + SecondNum;
        }
    }
    class GenString<T> : GenClass<T>
    {
        public object add(string FirstStr, string SecondStr)
        {
            return FirstStr + SecondStr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                GenClass<object> obj = new GenClass<object>();
                string str = "YES";
                do
                {
                    if (str.ToUpper().Equals("YES") || str.ToUpper().Equals("Y"))
                    {
                        Console.WriteLine("--------------------------GENERICS ADDING------------------------\n");
                        Console.WriteLine("\n1. Add two strings\n\n2. Add two numbers\n\nEnter any choice: \n\n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the first string: \n");
                                string FirstString = Console.ReadLine();
                                Console.WriteLine("\nEnter the second string: \n");
                                string SecondString = Console.ReadLine();
                                Console.WriteLine("\nAfter joining the two string the respective string is " + obj.add(FirstString, SecondString));
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the first  number: \n");
                                int FirstNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number: \n");
                                int SecondNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nAfter adding the two numbers the answer is " + obj.add(FirstNumber, SecondNumber));
                                break;
                            default:
                                Console.WriteLine("\nInvalid Input!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input!");
                    }
                    Console.WriteLine("\nDo you want to continue? (Yes/No)\n");
                    str = Console.ReadLine();
                } while (!str.ToUpper().Equals("NO") && !str.ToUpper().Equals("N"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

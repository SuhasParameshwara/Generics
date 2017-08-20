using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo27
{
    class GenDemo<T>
    {
        public string GenMethod(T val)
        {
            return val.ToString();
        }

    }
    class Demo
    {
        static void Main(string[] args)
        {
            try {
                GenDemo<object> obj = new GenDemo<object>();
                string str = "YES";
                do
                {
                    if (str.ToUpper().Equals("YES") || str.ToUpper().Equals("Y"))
                    {
                        Console.WriteLine("\nEnter any string: \n");
                        object temp = Console.ReadLine();
                        Console.WriteLine("\nThe equivalent string value is " + obj.GenMethod(temp));
                    }
                    else
                    {
                        Console.WriteLine("\nSorry Invalid Input!");
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

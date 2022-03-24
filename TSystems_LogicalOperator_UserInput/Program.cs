using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_LogicalOperator_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            Console.WriteLine("Enter First Value True or False");
            bool a = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Second Value True or False");
            bool b = Convert.ToBoolean(Console.ReadLine());

            bool result;

            result = a && b;
            Console.WriteLine($"The And operator would be\n{result}");

            result = a || b;
            Console.WriteLine($"The Or operator would be\n{result}");

            result = a != b;
            Console.WriteLine($"The Not Equal operator would be\n{result}");
            Console.ReadLine();
            goto start;





        }
    }
}

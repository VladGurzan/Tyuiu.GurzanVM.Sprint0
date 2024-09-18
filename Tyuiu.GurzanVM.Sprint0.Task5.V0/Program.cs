using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GurzanVM.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GurzanVM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataServes.Addition(1, 5));
            Console.WriteLine("A - B = " + DataServes.Subtraction(15, 5));
            Console.WriteLine("A + B = " + DataServes.Multiplication(10, 10));
            Console.WriteLine("a / b = " + DataServes.Division(9, 3));
            Console.ReadKey();
        }
    }
}

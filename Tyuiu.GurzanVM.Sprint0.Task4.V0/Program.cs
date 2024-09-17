using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurzanVM.Sprint0.Task4.V0.Lib;

namespace Tyuiu.GurzanVM.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataServes.Addition(1, 5));
            Console.WriteLine(DataServes.Subtraction(15, 5));
            Console.WriteLine(DataServes.Multiplication(10, 10));
            Console.WriteLine(DataServes.Division(5, 5));
            Console.ReadKey();

        }
    }
}

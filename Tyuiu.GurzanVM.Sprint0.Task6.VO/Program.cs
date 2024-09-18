using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurzanVM.Sprint0.Task6.V0.Lib;

namespace Tyuiu.GurzanVM.Sprint0.Task6.VO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

                Console.WriteLine("Сумма элементов массива = " + DataServies.AdditionArray(numsArray));
                Console.WriteLine("Разность элементов массива = " + DataServies.SubtrationArray(numsArray));
                Console.WriteLine("Произведение элемента массива = " + DataServies.MultiplicationArray(numsArray));

                Console.ReadKey();
            
        }
    }
}

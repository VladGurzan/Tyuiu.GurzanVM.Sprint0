using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurzanVM.Sprint0.Task7.V0.Lib;


namespace Tyuiu.GurzanVM.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Гурзан В. М. | Смартб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #0                                                                 ");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович | Смартб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0;  i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0;  i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {     
                    int[] resultArray = DataServies.AdditionArrays(arrayNums1, arrayNums2);

                    Console.WriteLine("Сумма элементов массива ровна:");
                for (int i = 0;  i < resultArray.Length; i++)
                {
                        Console.Write(resultArray[i] + ", ");
                }
                
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массива имеют разноет количество элементов");
            }
            Console.ReadKey();
        }    
    }
}

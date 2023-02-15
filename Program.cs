using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dimensional_arrays_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Задача 1. 
                //В одномерном массиве найти максимальный и минимальный элементы, а также их индексы. Поменять их местами и найти количество элементов между максимальным и минимальным элементами.

                int[] array = { -3, 5, 18, 19, -2, -4, 0, 9 };         //Явная инициализация массива
                int i;
                int max = array[0];           //Поиск максимального значения
                int imax = 0;
                for (i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        imax = i;
                    }
                }
                Console.WriteLine($"Мax: {max} \tIndex: {imax}");

                int min = array[0];           //Поиск минимального значения
                int imin = 0;
                for (i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        imin = i;
                    }
                }
                Console.WriteLine($"Min: {min} \tIndex: {imin}\n");

                int p = array[imax];                //Меняем местами максимальное и минимальное число
                array[imax] = array[imin];
                array[imin] = p;
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array[{i}] = {array[i]}\tIndex: {i}");
                }

                Console.WriteLine($"Количество элементов между макс. и мин. элементов: {Math.Abs(imax - imin)}\n");   //Поиск количества элементов между значениями
                Console.WriteLine("Увеличиваем на модуль разности минимального и максимального элемента все значения:\n");
                for(i=0;i<array.Length;i++)
                {
                    Console.Write($"{array[i] + Math.Abs(array[imin]-array[imax])}\t");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}

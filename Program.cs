using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 10, 0, 1, -3, 6, -5, 4, 0, 2, 7 };
            Random(mas);
            ex14();
            ex15();
            ex16();
            Console.WriteLine(ex17(mas));
            Console.WriteLine(ex18(mas));
           
            Console.WriteLine(ex20(mas));
        }
        private static void Random()
        {

        }
        private static void ex14()
        {
            int[] array = { 1, 2, 3, 4, 0, 6, 7, 0 };
            int k = Array.IndexOf(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                if (i < k)
                {
                    array[i] = array[i] * 2;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex15()
        {
            int[] array = { 1, 2, 3, 0, 7, 5, 0 };
            int min = array[0];
            int k = Array.LastIndexOf(array, 0);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    min = array[i];
                }
                array[k] = min;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex16()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 2; i < array.Length; i += 3)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static int ex17()
        {
            int[] array = { 9, 10, -2, -5 };
            int max = array.Max();
            int proizv = 1;
            int k = Array.IndexOf(array, max);
            for (int i = 0; i < array.Length; i++)
            {
                if (i > k)
                {
                    if (array[i] < 0)
                    {
                        proizv = proizv * array[i];
                    }
                }
            }
            return(proizv);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int ex18(int[] array)
        {
          
            int k = Array.LastIndexOf(array, 0);
            int min = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (i > k)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }
           return(min);
        }

        private static void PrintArr(int[] mas)
        {
            
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            
        }

        /// <summary>
        /// Сортировка подсчетом
        /// </summary>
        /// <param name="mas"></param>
        private static int[] sortirovkapodschetom(int[] mas)
        {
           
           
            int k = mas.Max();
            int[] count = new int[k + 1];
            for (var i = 0; i < mas.Length; i++)
            {
                count[mas[i]]++;
                //count[0]
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    mas[index] = i;
                    index++;
                }
            }

            for (int i = 0; i < mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }
            return mas;
        }

        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        private static int[] sortirovkaviborom(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int k = mas[i];
                int j = i - 1;

                while (j >= 0 && mas[j] > k)
                {
                    mas[j + 1] = mas[j];
                    mas[j] = k;
                    j--;
                }
            }

            return mas;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        private static int[] ex20(int[] mas)
        {
            int min = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == min)
                {
                    mas[i] = Convert.ToInt32(Math.Pow(min, 2));
                }
                
            }
            return mas;
        }

        /// <summary>
        ///  Сортировка выбором
        /// </summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        private static int[] sort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;

            }
            return mas;
           
        }
    }
}

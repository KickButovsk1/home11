using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 3, 0, 9, 9, 2, 7, 7 };
            int[] mass = { 0, 5, 2, 4, 9, 5, -4, -3, 5 };
            int[] prOtr = ProizvOtrElem(mass);
            Console.WriteLine("---------------------------------------------------------");
            int minPN = MinPosleNull(array);
            Console.WriteLine(minPN);
            Console.WriteLine("---------------------------------------------------------");
            int mEl = MaxElement(array);
            Console.WriteLine(mEl);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            int[] sortp = SortPodschet(array);
            foreach (var item in sortp)
            {
                Console.Write(item + "\t");
            }

        }
/// <summary>
/// Произведение отрицательных элементов
/// </summary>
/// <param name="mass"></param>
/// <returns></returns>
        private static int[] ProizvOtrElem(int[] mass)
        {
            int w = Array.LastIndexOf(mass, mass.Max());
            int max = mass.Max();
            int proizv = 1;
            for (int i = 0; i < mass.Length; i++)
            {
                if (i > w)
                {
                    if (mass[i] < 0)
                    {
                        proizv = proizv * mass[i];
                    }
                }
            }
            Console.WriteLine(proizv);
            return mass;
        }
        /// <summary>
        /// Минимальное число после нуля
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int MinPosleNull(int[] array)
        {
            int w = Array.LastIndexOf(array, 0);
            int min = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (i > w)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }
            return min;
        }
        /// <summary>
        /// Максимальный элемент
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int MaxElement(int[] array)
        {
            int w = array.Max();
            return w;
        }

        /// <summary>
        /// Сортировка подсчетом
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[] SortPodschet(int[] array)
        {
            int k = MaxElement(array);
            int[] count = new int[k+1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
        /// <summary>
        /// Минимальная отрицательная сума
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
            private static int[] MinOtrSum(int[] array)
            {
                double min = array[0];
                double sumotr = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        min = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        sumotr += array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == min)
                    {
                        array[i] = Convert.ToInt32(sumotr);
                    }
                }
            return array;
            }

            /// <summary>
            /// Минимальные элементы в квадрат
            /// </summary>
            /// <param name="array"></param>
            /// <returns></returns>
            private static int[] PowMin(int[] array)
            {
                double min = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == min)
                    {
                        array[i] = Convert.ToInt32(Math.Pow(array[i], 2));
                    }
                }
                return array;
            }

            /// <summary>
            /// Сортировка 
            /// </summary>
            /// <param name="array"></param>
            /// <returns></returns>
            private static int[] SortArray(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //поиск минимального числа
                    int min = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[min])
                        {
                            min = j;
                        }
                    }
                    //обмен элементов
                    int temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
                return array;
            }
        }
    }
